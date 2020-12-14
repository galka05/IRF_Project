namespace Project_ar0ez3
{
    partial class Form3
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.salesDatabaseDataSet = new Project_ar0ez3.SalesDatabaseDataSet();
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesTableAdapter = new Project_ar0ez3.SalesDatabaseDataSetTableAdapters.SalesTableAdapter();
            this.salesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.salesIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productFKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sales2014DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sales2015DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sales2016DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sales2017DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sales2018DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sales2019DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.salesIDDataGridViewTextBoxColumn,
            this.productFKDataGridViewTextBoxColumn,
            this.sales2014DataGridViewTextBoxColumn,
            this.sales2015DataGridViewTextBoxColumn,
            this.sales2016DataGridViewTextBoxColumn,
            this.sales2017DataGridViewTextBoxColumn,
            this.sales2018DataGridViewTextBoxColumn,
            this.sales2019DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.salesBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(47, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1064, 155);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.DataSource = this.salesBindingSource;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(47, 187);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(831, 371);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // salesDatabaseDataSet
            // 
            this.salesDatabaseDataSet.DataSetName = "SalesDatabaseDataSet";
            this.salesDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesBindingSource
            // 
            this.salesBindingSource.DataMember = "Sales";
            this.salesBindingSource.DataSource = this.salesDatabaseDataSet;
            // 
            // salesTableAdapter
            // 
            this.salesTableAdapter.ClearBeforeFill = true;
            // 
            // salesBindingSource1
            // 
            this.salesBindingSource1.DataMember = "Sales";
            this.salesBindingSource1.DataSource = this.salesDatabaseDataSet;
            // 
            // salesIDDataGridViewTextBoxColumn
            // 
            this.salesIDDataGridViewTextBoxColumn.DataPropertyName = "SalesID";
            this.salesIDDataGridViewTextBoxColumn.HeaderText = "SalesID";
            this.salesIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.salesIDDataGridViewTextBoxColumn.Name = "salesIDDataGridViewTextBoxColumn";
            this.salesIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.salesIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // productFKDataGridViewTextBoxColumn
            // 
            this.productFKDataGridViewTextBoxColumn.DataPropertyName = "ProductFK";
            this.productFKDataGridViewTextBoxColumn.HeaderText = "ProductFK";
            this.productFKDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productFKDataGridViewTextBoxColumn.Name = "productFKDataGridViewTextBoxColumn";
            this.productFKDataGridViewTextBoxColumn.Width = 125;
            // 
            // sales2014DataGridViewTextBoxColumn
            // 
            this.sales2014DataGridViewTextBoxColumn.DataPropertyName = "Sales_2014";
            this.sales2014DataGridViewTextBoxColumn.HeaderText = "Sales_2014";
            this.sales2014DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sales2014DataGridViewTextBoxColumn.Name = "sales2014DataGridViewTextBoxColumn";
            this.sales2014DataGridViewTextBoxColumn.Width = 125;
            // 
            // sales2015DataGridViewTextBoxColumn
            // 
            this.sales2015DataGridViewTextBoxColumn.DataPropertyName = "Sales_2015";
            this.sales2015DataGridViewTextBoxColumn.HeaderText = "Sales_2015";
            this.sales2015DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sales2015DataGridViewTextBoxColumn.Name = "sales2015DataGridViewTextBoxColumn";
            this.sales2015DataGridViewTextBoxColumn.Width = 125;
            // 
            // sales2016DataGridViewTextBoxColumn
            // 
            this.sales2016DataGridViewTextBoxColumn.DataPropertyName = "Sales_2016";
            this.sales2016DataGridViewTextBoxColumn.HeaderText = "Sales_2016";
            this.sales2016DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sales2016DataGridViewTextBoxColumn.Name = "sales2016DataGridViewTextBoxColumn";
            this.sales2016DataGridViewTextBoxColumn.Width = 125;
            // 
            // sales2017DataGridViewTextBoxColumn
            // 
            this.sales2017DataGridViewTextBoxColumn.DataPropertyName = "Sales_2017";
            this.sales2017DataGridViewTextBoxColumn.HeaderText = "Sales_2017";
            this.sales2017DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sales2017DataGridViewTextBoxColumn.Name = "sales2017DataGridViewTextBoxColumn";
            this.sales2017DataGridViewTextBoxColumn.Width = 125;
            // 
            // sales2018DataGridViewTextBoxColumn
            // 
            this.sales2018DataGridViewTextBoxColumn.DataPropertyName = "Sales_2018";
            this.sales2018DataGridViewTextBoxColumn.HeaderText = "Sales_2018";
            this.sales2018DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sales2018DataGridViewTextBoxColumn.Name = "sales2018DataGridViewTextBoxColumn";
            this.sales2018DataGridViewTextBoxColumn.Width = 125;
            // 
            // sales2019DataGridViewTextBoxColumn
            // 
            this.sales2019DataGridViewTextBoxColumn.DataPropertyName = "Sales_2019";
            this.sales2019DataGridViewTextBoxColumn.HeaderText = "Sales_2019";
            this.sales2019DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sales2019DataGridViewTextBoxColumn.Name = "sales2019DataGridViewTextBoxColumn";
            this.sales2019DataGridViewTextBoxColumn.Width = 125;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 589);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private SalesDatabaseDataSet salesDatabaseDataSet;
        private System.Windows.Forms.BindingSource salesBindingSource;
        private SalesDatabaseDataSetTableAdapters.SalesTableAdapter salesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productFKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sales2014DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sales2015DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sales2016DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sales2017DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sales2018DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sales2019DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource salesBindingSource1;
    }
}