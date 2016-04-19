using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Demo.Service.Services;

namespace TransactionRebateDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            vw_SalesByProductTableAdapter.FillByProductType(dataSetSalesByProduct.vw_SalesByProduct);
            vw_RebateByUnitsByCustomerTableAdapter.FillByOrderByRebates(dataSetRebateByUnit.vw_RebateByUnitsByCustomer);
            vw_RebateByRevenueByCustomerTableAdapter.FillBy(testDataSet1.vw_RebateByRevenueByCustomer);
            transactionRecordTableAdapter1.Fill(customerWithSales.TransactionRecord);
            transactionRecordTableAdapter.Fill(testDataSet.TransactionRecord);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var rebateService = new RebateService();
            rebateService.InsertDataIntoDatabase(ConfigurationManager.AppSettings["ProductRebatesFileLocation"],
                ConfigurationManager.AppSettings["TransactionsFileLocation"]);
            transactionRecordTableAdapter.Fill(testDataSet.TransactionRecord);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            //Note: I'm sure there's a better way to do this, but I have't used WinForms in a long time and wanted to make something work for now
            labelDataDoneLoading.Visible = false;
            var strConnectionString =
                ConfigurationManager.ConnectionStrings["TransactionRebateDemo.Properties.Settings.TestConnectionString"]
                    .ConnectionString;
            using (var con = new SqlConnection(strConnectionString))
            {
                var cmd = new SqlCommand("sp_GetSalesByInvoiceDate", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@fromDate", dateTimePickerFromDate.Value);
                cmd.Parameters.AddWithValue("@toDate", dateTimePickerToDate.Value);

                con.Open();
                cmd.ExecuteNonQuery();

                using (var adap = new SqlDataAdapter(cmd))
                {
                    var dt = new DataTable();
                    adap.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }

            vw_SalesByProductTableAdapter.FillByProductType(dataSetSalesByProduct.vw_SalesByProduct);
            vw_RebateByUnitsByCustomerTableAdapter.FillByOrderByRebates(dataSetRebateByUnit.vw_RebateByUnitsByCustomer);
            vw_RebateByRevenueByCustomerTableAdapter.FillBy(testDataSet1.vw_RebateByRevenueByCustomer);
            labelDataDoneLoading.Visible = true;
        }

        private void dateTimePickerFromDate_ValueChanged(object sender, EventArgs e)
        {
        }

        private void transactionRecordBindingSource_CurrentChanged(object sender, EventArgs e)
        {
        }
    }
}