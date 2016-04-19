using System.Collections.Generic;
using System.Linq;
using Demo.Model.File;
using Demo.Service.Configuration;
using FileHelpers;
using Transaction = Demo.Model.Database.Transaction;

namespace Demo.Service.Services
{
    public class RebateService
    {
        public void InsertDataIntoDatabase(string rebateFileLocation, string transactionFileLocation)
        {
            var transactionRecords = ReadDataFromCsv<Model.File.Transaction>(transactionFileLocation);
            var rebateRecords = ReadDataFromCsv<ProductRebate>(rebateFileLocation);
            var transactionsWithRebates = CalculateRebates(transactionRecords, rebateRecords);
            SaveTransactions(transactionsWithRebates);
        }

        private void SaveTransactions(IEnumerable<Transaction> transactionsWithRebates)
        {
            //NOTE: This takes longer than I'd like, but Nhibernate is what I know best, so was faster for me to write
            //Ideally I'd take more time to research this and look at something that handles 'larger' amounts of data better/faster
            var sessionProvider = new SessionProvider();
            using (var session = sessionProvider.GetSessionFactory().OpenStatelessSession())
            using (var transaction = session.BeginTransaction())
            {
                session.SetBatchSize(100);
                foreach (var transactionsWithRebate in transactionsWithRebates.ToList())
                {
                    session.Insert(transactionsWithRebate);
                }
                transaction.Commit();
            }
        }

        private IEnumerable<Transaction> CalculateRebates(IEnumerable<Model.File.Transaction> transactionRecords,
            IEnumerable<ProductRebate> rebateRecords)
        {
            var transactionsWithRebates = new List<Transaction>();
            var transList = transactionRecords.ToList();
            var rebateGroups =
                rebateRecords
                    .GroupBy(x => new {x.Month, x.Year, x.ProductType})
                    .Select(
                        group =>
                            new
                            {
                                RebateTotal = group.Sum(x => x.RebateAmount),
                                group.Key.Month,
                                group.Key.Year,
                                group.Key.ProductType
                            }
                    ).ToArray();

            foreach (var productRebateGroup in rebateGroups)
            {
                var transInTheTimeFrame = transList.Where(
                    x =>
                        x.InvoiceDate.Value.Month == productRebateGroup.Month &&
                        x.InvoiceDate.Value.Year == productRebateGroup.Year &&
                        x.ProductType == productRebateGroup.ProductType).ToList();

                var sumOfSalesInTimeframe = transInTheTimeFrame.Sum(x => x.SalesAmount);
                var totalNumberOfSalesInTimeFrame = transInTheTimeFrame.Sum(x => x.SalesQty);

                transInTheTimeFrame.ForEach(trans => transactionsWithRebates.Add(new Transaction
                {
                    Cost = trans.Cost,
                    Customer = trans.Customer,
                    InvoiceDate = trans.InvoiceDate,
                    Product = trans.Product,
                    ProductType = trans.ProductType,
                    RebateByUnits =
                        (decimal) trans.SalesQty/totalNumberOfSalesInTimeFrame*productRebateGroup.RebateTotal,
                    RebateByRevenue = trans.SalesAmount/sumOfSalesInTimeframe*productRebateGroup.RebateTotal,
                    Region = trans.Region,
                    SalesAmount = trans.SalesAmount,
                    SalesOrder = trans.SalesOrder,
                    SalesQty = trans.SalesQty
                }));
            }

            return transactionsWithRebates;
        }


        private IEnumerable<T> ReadDataFromCsv<T>(string fileLocation) where T : class
        {
            var tranactionEngine = new FileHelperEngine<T>();
            var records = tranactionEngine.ReadFile(fileLocation);
            return records;
        }
    }
}