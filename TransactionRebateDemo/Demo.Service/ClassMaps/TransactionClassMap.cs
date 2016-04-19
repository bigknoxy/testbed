using Demo.Model.Database;
using FluentNHibernate.Mapping;

namespace Demo.Service.ClassMaps
{
    public class TransactionClassMap : ClassMap<Transaction>
    {
        public TransactionClassMap()
        {
            Schema("dbo");
            Table("TransactionRecord");
            Id(x => x.Id).Column("TransactionId");
            Map(x => x.Region);
            Map(x => x.Customer);
            Map(x => x.SalesOrder);
            Map(x => x.ProductType);
            Map(x => x.Product);
            Map(x => x.Uom);
            Map(x => x.Cost);
            Map(x => x.InvoiceDate);
            Map(x => x.SalesQty);
            Map(x => x.SalesAmount);
            Map(x => x.RebateByRevenue);
            Map(x => x.RebateByUnits);
        }
    }
}