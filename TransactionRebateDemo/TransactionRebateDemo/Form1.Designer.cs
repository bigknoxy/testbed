namespace TransactionRebateDemo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ButtonImportData = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ButtonRefresh = new System.Windows.Forms.Button();
            this.dateTimePickerToDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerFromDate = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalSales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spGetSalesByInvoiceDateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetSalesByInvoice = new TransactionRebateDemo.DataSetSalesByInvoice();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.customerDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalRebateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwRebateByRevenueByCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDataSet1 = new TransactionRebateDemo.TestDataSet1();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.customerDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalRebateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwRebateByUnitsByCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetRebateByUnit = new TransactionRebateDemo.DataSetRebateByUnit();
            this.tabSalesByProduct = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.productTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalSalesAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalSalesQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwSalesByProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetSalesByProduct = new TransactionRebateDemo.DataSetSalesByProduct();
            this.transactionRecordBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customerWithSales = new TransactionRebateDemo.CustomerWithSales();
            this.transactionRecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDataSet = new TransactionRebateDemo.TestDataSet();
            this.transactionRecordTableAdapter = new TransactionRebateDemo.TestDataSetTableAdapters.TransactionRecordTableAdapter();
            this.transactionRecordTableAdapter1 = new TransactionRebateDemo.CustomerWithSalesTableAdapters.TransactionRecordTableAdapter();
            this.vw_RebateByRevenueByCustomerTableAdapter = new TransactionRebateDemo.TestDataSet1TableAdapters.vw_RebateByRevenueByCustomerTableAdapter();
            this.customerWithSalesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_GetSalesByInvoiceDateTableAdapter = new TransactionRebateDemo.DataSetSalesByInvoiceTableAdapters.sp_GetSalesByInvoiceDateTableAdapter();
            this.vw_RebateByUnitsByCustomerTableAdapter = new TransactionRebateDemo.DataSetRebateByUnitTableAdapters.vw_RebateByUnitsByCustomerTableAdapter();
            this.vw_SalesByProductTableAdapter = new TransactionRebateDemo.DataSetSalesByProductTableAdapters.vw_SalesByProductTableAdapter();
            this.labelDataDoneLoading = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetSalesByInvoiceDateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSalesByInvoice)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwRebateByRevenueByCustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwRebateByUnitsByCustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRebateByUnit)).BeginInit();
            this.tabSalesByProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwSalesByProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSalesByProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionRecordBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerWithSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionRecordBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerWithSalesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonImportData
            // 
            this.ButtonImportData.Location = new System.Drawing.Point(12, 41);
            this.ButtonImportData.Name = "ButtonImportData";
            this.ButtonImportData.Size = new System.Drawing.Size(122, 23);
            this.ButtonImportData.TabIndex = 0;
            this.ButtonImportData.Text = "Import Data into DB";
            this.ButtonImportData.UseVisualStyleBackColor = true;
            this.ButtonImportData.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabSalesByProduct);
            this.tabControl1.Location = new System.Drawing.Point(21, 80);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(745, 381);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ButtonRefresh);
            this.tabPage1.Controls.Add(this.dateTimePickerToDate);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dateTimePickerFromDate);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(737, 355);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sale Summary";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ButtonRefresh
            // 
            this.ButtonRefresh.Location = new System.Drawing.Point(518, 13);
            this.ButtonRefresh.Name = "ButtonRefresh";
            this.ButtonRefresh.Size = new System.Drawing.Size(102, 23);
            this.ButtonRefresh.TabIndex = 2;
            this.ButtonRefresh.Text = "RefreshDataGrid";
            this.ButtonRefresh.UseVisualStyleBackColor = true;
            this.ButtonRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // dateTimePickerToDate
            // 
            this.dateTimePickerToDate.Location = new System.Drawing.Point(301, 15);
            this.dateTimePickerToDate.Name = "dateTimePickerToDate";
            this.dateTimePickerToDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerToDate.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "To:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "From:";
            // 
            // dateTimePickerFromDate
            // 
            this.dateTimePickerFromDate.Location = new System.Drawing.Point(45, 16);
            this.dateTimePickerFromDate.Name = "dateTimePickerFromDate";
            this.dateTimePickerFromDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFromDate.TabIndex = 1;
            this.dateTimePickerFromDate.Value = new System.DateTime(2011, 2, 1, 0, 0, 0, 0);
            this.dateTimePickerFromDate.ValueChanged += new System.EventHandler(this.dateTimePickerFromDate_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerDataGridViewTextBoxColumn,
            this.TotalSales});
            this.dataGridView1.DataSource = this.spGetSalesByInvoiceDateBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(702, 279);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "Customer";
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            this.customerDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerDataGridViewTextBoxColumn.Width = 76;
            // 
            // TotalSales
            // 
            this.TotalSales.DataPropertyName = "TotalSales";
            this.TotalSales.HeaderText = "TotalSales";
            this.TotalSales.Name = "TotalSales";
            this.TotalSales.ReadOnly = true;
            // 
            // spGetSalesByInvoiceDateBindingSource
            // 
            this.spGetSalesByInvoiceDateBindingSource.DataMember = "sp_GetSalesByInvoiceDate";
            this.spGetSalesByInvoiceDateBindingSource.DataSource = this.dataSetSalesByInvoice;
            // 
            // dataSetSalesByInvoice
            // 
            this.dataSetSalesByInvoice.DataSetName = "DataSetSalesByInvoice";
            this.dataSetSalesByInvoice.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.dataGridView3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(737, 355);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "RebateByRevenue";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerDataGridViewTextBoxColumn2,
            this.totalRebateDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.vwRebateByRevenueByCustomerBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(-4, 2);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(735, 350);
            this.dataGridView3.TabIndex = 0;
            // 
            // customerDataGridViewTextBoxColumn2
            // 
            this.customerDataGridViewTextBoxColumn2.DataPropertyName = "Customer";
            this.customerDataGridViewTextBoxColumn2.HeaderText = "Customer";
            this.customerDataGridViewTextBoxColumn2.Name = "customerDataGridViewTextBoxColumn2";
            this.customerDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // totalRebateDataGridViewTextBoxColumn
            // 
            this.totalRebateDataGridViewTextBoxColumn.DataPropertyName = "TotalRebate";
            this.totalRebateDataGridViewTextBoxColumn.HeaderText = "TotalRebate";
            this.totalRebateDataGridViewTextBoxColumn.Name = "totalRebateDataGridViewTextBoxColumn";
            this.totalRebateDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalRebateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // vwRebateByRevenueByCustomerBindingSource
            // 
            this.vwRebateByRevenueByCustomerBindingSource.DataMember = "vw_RebateByRevenueByCustomer";
            this.vwRebateByRevenueByCustomerBindingSource.DataSource = this.testDataSet1;
            // 
            // testDataSet1
            // 
            this.testDataSet1.DataSetName = "TestDataSet1";
            this.testDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(737, 355);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "RebateByUnit";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerDataGridViewTextBoxColumn3,
            this.totalRebateDataGridViewTextBoxColumn1});
            this.dataGridView4.DataSource = this.vwRebateByUnitsByCustomerBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(3, 3);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(731, 349);
            this.dataGridView4.TabIndex = 0;
            // 
            // customerDataGridViewTextBoxColumn3
            // 
            this.customerDataGridViewTextBoxColumn3.DataPropertyName = "Customer";
            this.customerDataGridViewTextBoxColumn3.HeaderText = "Customer";
            this.customerDataGridViewTextBoxColumn3.Name = "customerDataGridViewTextBoxColumn3";
            // 
            // totalRebateDataGridViewTextBoxColumn1
            // 
            this.totalRebateDataGridViewTextBoxColumn1.DataPropertyName = "TotalRebate";
            this.totalRebateDataGridViewTextBoxColumn1.HeaderText = "TotalRebate";
            this.totalRebateDataGridViewTextBoxColumn1.Name = "totalRebateDataGridViewTextBoxColumn1";
            // 
            // vwRebateByUnitsByCustomerBindingSource
            // 
            this.vwRebateByUnitsByCustomerBindingSource.DataMember = "vw_RebateByUnitsByCustomer";
            this.vwRebateByUnitsByCustomerBindingSource.DataSource = this.dataSetRebateByUnit;
            // 
            // dataSetRebateByUnit
            // 
            this.dataSetRebateByUnit.DataSetName = "DataSetRebateByUnit";
            this.dataSetRebateByUnit.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabSalesByProduct
            // 
            this.tabSalesByProduct.AutoScroll = true;
            this.tabSalesByProduct.Controls.Add(this.dataGridView2);
            this.tabSalesByProduct.Location = new System.Drawing.Point(4, 22);
            this.tabSalesByProduct.Name = "tabSalesByProduct";
            this.tabSalesByProduct.Size = new System.Drawing.Size(737, 355);
            this.tabSalesByProduct.TabIndex = 3;
            this.tabSalesByProduct.Text = "SalesByProduct";
            this.tabSalesByProduct.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productTypeDataGridViewTextBoxColumn,
            this.totalSalesAmountDataGridViewTextBoxColumn,
            this.totalSalesQtyDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.vwSalesByProductBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(731, 349);
            this.dataGridView2.TabIndex = 0;
            // 
            // productTypeDataGridViewTextBoxColumn
            // 
            this.productTypeDataGridViewTextBoxColumn.DataPropertyName = "ProductType";
            this.productTypeDataGridViewTextBoxColumn.HeaderText = "ProductType";
            this.productTypeDataGridViewTextBoxColumn.Name = "productTypeDataGridViewTextBoxColumn";
            this.productTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalSalesAmountDataGridViewTextBoxColumn
            // 
            this.totalSalesAmountDataGridViewTextBoxColumn.DataPropertyName = "TotalSalesAmount";
            this.totalSalesAmountDataGridViewTextBoxColumn.HeaderText = "TotalSalesAmount";
            this.totalSalesAmountDataGridViewTextBoxColumn.Name = "totalSalesAmountDataGridViewTextBoxColumn";
            this.totalSalesAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalSalesQtyDataGridViewTextBoxColumn
            // 
            this.totalSalesQtyDataGridViewTextBoxColumn.DataPropertyName = "TotalSalesQty";
            this.totalSalesQtyDataGridViewTextBoxColumn.HeaderText = "TotalSalesQty";
            this.totalSalesQtyDataGridViewTextBoxColumn.Name = "totalSalesQtyDataGridViewTextBoxColumn";
            this.totalSalesQtyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vwSalesByProductBindingSource
            // 
            this.vwSalesByProductBindingSource.DataMember = "vw_SalesByProduct";
            this.vwSalesByProductBindingSource.DataSource = this.dataSetSalesByProduct;
            // 
            // dataSetSalesByProduct
            // 
            this.dataSetSalesByProduct.DataSetName = "DataSetSalesByProduct";
            this.dataSetSalesByProduct.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transactionRecordBindingSource1
            // 
            this.transactionRecordBindingSource1.DataMember = "TransactionRecord";
            this.transactionRecordBindingSource1.DataSource = this.customerWithSales;
            // 
            // customerWithSales
            // 
            this.customerWithSales.DataSetName = "CustomerWithSales";
            this.customerWithSales.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transactionRecordBindingSource
            // 
            this.transactionRecordBindingSource.DataMember = "TransactionRecord";
            this.transactionRecordBindingSource.DataSource = this.testDataSet;
            this.transactionRecordBindingSource.CurrentChanged += new System.EventHandler(this.transactionRecordBindingSource_CurrentChanged);
            // 
            // testDataSet
            // 
            this.testDataSet.DataSetName = "TestDataSet";
            this.testDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transactionRecordTableAdapter
            // 
            this.transactionRecordTableAdapter.ClearBeforeFill = true;
            // 
            // transactionRecordTableAdapter1
            // 
            this.transactionRecordTableAdapter1.ClearBeforeFill = true;
            // 
            // vw_RebateByRevenueByCustomerTableAdapter
            // 
            this.vw_RebateByRevenueByCustomerTableAdapter.ClearBeforeFill = true;
            // 
            // customerWithSalesBindingSource
            // 
            this.customerWithSalesBindingSource.DataSource = this.customerWithSales;
            this.customerWithSalesBindingSource.Position = 0;
            // 
            // sp_GetSalesByInvoiceDateTableAdapter
            // 
            this.sp_GetSalesByInvoiceDateTableAdapter.ClearBeforeFill = true;
            // 
            // vw_RebateByUnitsByCustomerTableAdapter
            // 
            this.vw_RebateByUnitsByCustomerTableAdapter.ClearBeforeFill = true;
            // 
            // vw_SalesByProductTableAdapter
            // 
            this.vw_SalesByProductTableAdapter.ClearBeforeFill = true;
            // 
            // labelDataDoneLoading
            // 
            this.labelDataDoneLoading.AutoSize = true;
            this.labelDataDoneLoading.Location = new System.Drawing.Point(158, 46);
            this.labelDataDoneLoading.Name = "labelDataDoneLoading";
            this.labelDataDoneLoading.Size = new System.Drawing.Size(100, 13);
            this.labelDataDoneLoading.TabIndex = 2;
            this.labelDataDoneLoading.Text = "Data Done Loading";
            this.labelDataDoneLoading.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 473);
            this.Controls.Add(this.labelDataDoneLoading);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.ButtonImportData);
            this.Name = "Form1";
            this.Text = "Josh Knox Demo App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetSalesByInvoiceDateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSalesByInvoice)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwRebateByRevenueByCustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwRebateByUnitsByCustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRebateByUnit)).EndInit();
            this.tabSalesByProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwSalesByProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSalesByProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionRecordBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerWithSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionRecordBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerWithSalesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonImportData;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private TestDataSet testDataSet;
        private System.Windows.Forms.BindingSource transactionRecordBindingSource;
        private TestDataSetTableAdapters.TransactionRecordTableAdapter transactionRecordTableAdapter;
        private System.Windows.Forms.Button ButtonRefresh;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DateTimePicker dateTimePickerToDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerFromDate;
        private System.Windows.Forms.TabPage tabSalesByProduct;
        private System.Windows.Forms.DataGridView dataGridView2;
        private CustomerWithSales customerWithSales;
        private System.Windows.Forms.BindingSource transactionRecordBindingSource1;
        private CustomerWithSalesTableAdapters.TransactionRecordTableAdapter transactionRecordTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private TestDataSet1 testDataSet1;
        private System.Windows.Forms.BindingSource vwRebateByRevenueByCustomerBindingSource;
        private TestDataSet1TableAdapters.vw_RebateByRevenueByCustomerTableAdapter vw_RebateByRevenueByCustomerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalRebateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource customerWithSalesBindingSource;
        private System.Windows.Forms.BindingSource spGetSalesByInvoiceDateBindingSource;
        private DataSetSalesByInvoice dataSetSalesByInvoice;
        private DataSetSalesByInvoiceTableAdapters.sp_GetSalesByInvoiceDateTableAdapter sp_GetSalesByInvoiceDateTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalSales;
        private System.Windows.Forms.DataGridView dataGridView4;
        private DataSetRebateByUnit dataSetRebateByUnit;
        private System.Windows.Forms.BindingSource vwRebateByUnitsByCustomerBindingSource;
        private DataSetRebateByUnitTableAdapters.vw_RebateByUnitsByCustomerTableAdapter vw_RebateByUnitsByCustomerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalRebateDataGridViewTextBoxColumn1;
        private DataSetSalesByProduct dataSetSalesByProduct;
        private System.Windows.Forms.BindingSource vwSalesByProductBindingSource;
        private DataSetSalesByProductTableAdapters.vw_SalesByProductTableAdapter vw_SalesByProductTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalSalesAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalSalesQtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label labelDataDoneLoading;
    }
}

