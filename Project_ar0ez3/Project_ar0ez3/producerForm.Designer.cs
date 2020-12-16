namespace Project_ar0ez3
{
    partial class producerForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesDatabaseDataSet = new Project_ar0ez3.SalesDatabaseDataSet();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.producerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.producerTableAdapter = new Project_ar0ez3.SalesDatabaseDataSetTableAdapters.ProducerTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.prodChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.fKProductToProducerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new Project_ar0ez3.SalesDatabaseDataSetTableAdapters.ProductTableAdapter();
            this.salesTableAdapter = new Project_ar0ez3.SalesDatabaseDataSetTableAdapters.SalesTableAdapter();
            this.sales2014DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sales2015DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sales2016DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sales2017DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sales2018DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sales2019DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.producerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKProductToProducerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sales2014DataGridViewTextBoxColumn,
            this.sales2015DataGridViewTextBoxColumn,
            this.sales2016DataGridViewTextBoxColumn,
            this.sales2017DataGridViewTextBoxColumn,
            this.sales2018DataGridViewTextBoxColumn,
            this.sales2019DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.salesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(63, 575);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(148, 27);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Visible = false;
            // 
            // salesBindingSource
            // 
            this.salesBindingSource.DataMember = "Sales";
            this.salesBindingSource.DataSource = this.salesDatabaseDataSet;
            // 
            // salesDatabaseDataSet
            // 
            this.salesDatabaseDataSet.DataSetName = "SalesDatabaseDataSet";
            this.salesDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(270, 150);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Sales";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(850, 500);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.producerBindingSource;
            this.comboBox1.DisplayMember = "Producer_name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(15, 150);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(240, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.ValueMember = "ProducerID";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // producerBindingSource
            // 
            this.producerBindingSource.DataMember = "Producer";
            this.producerBindingSource.DataSource = this.salesDatabaseDataSet;
            // 
            // producerTableAdapter
            // 
            this.producerTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1000, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 23);
            this.label6.TabIndex = 20;
            this.label6.Text = "2019";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(860, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 23);
            this.label5.TabIndex = 19;
            this.label5.Text = "2018";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(720, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 23);
            this.label4.TabIndex = 18;
            this.label4.Text = "2017";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(570, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 23);
            this.label3.TabIndex = 17;
            this.label3.Text = "2016";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(420, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "2015";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "2014";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(59, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 22);
            this.label7.TabIndex = 21;
            this.label7.Text = "Sales by Year:";
            // 
            // prodChart
            // 
            chartArea2.Name = "ChartArea1";
            this.prodChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.prodChart.Legends.Add(legend2);
            this.prodChart.Location = new System.Drawing.Point(270, 152);
            this.prodChart.Name = "prodChart";
            this.prodChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Sales";
            this.prodChart.Series.Add(series2);
            this.prodChart.Size = new System.Drawing.Size(850, 500);
            this.prodChart.TabIndex = 2;
            this.prodChart.Text = "chart1";
            // 
            // fKProductToProducerBindingSource
            // 
            this.fKProductToProducerBindingSource.DataMember = "FK_Product_ToProducer";
            this.fKProductToProducerBindingSource.DataSource = this.producerBindingSource;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // salesTableAdapter
            // 
            this.salesTableAdapter.ClearBeforeFill = true;
            // 
            // sales2014DataGridViewTextBoxColumn
            // 
            this.sales2014DataGridViewTextBoxColumn.DataPropertyName = "Sales_2014";
            this.sales2014DataGridViewTextBoxColumn.HeaderText = "Sales_2014";
            this.sales2014DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sales2014DataGridViewTextBoxColumn.Name = "sales2014DataGridViewTextBoxColumn";
            this.sales2014DataGridViewTextBoxColumn.ReadOnly = true;
            this.sales2014DataGridViewTextBoxColumn.Width = 125;
            // 
            // sales2015DataGridViewTextBoxColumn
            // 
            this.sales2015DataGridViewTextBoxColumn.DataPropertyName = "Sales_2015";
            this.sales2015DataGridViewTextBoxColumn.HeaderText = "Sales_2015";
            this.sales2015DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sales2015DataGridViewTextBoxColumn.Name = "sales2015DataGridViewTextBoxColumn";
            this.sales2015DataGridViewTextBoxColumn.ReadOnly = true;
            this.sales2015DataGridViewTextBoxColumn.Width = 125;
            // 
            // sales2016DataGridViewTextBoxColumn
            // 
            this.sales2016DataGridViewTextBoxColumn.DataPropertyName = "Sales_2016";
            this.sales2016DataGridViewTextBoxColumn.HeaderText = "Sales_2016";
            this.sales2016DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sales2016DataGridViewTextBoxColumn.Name = "sales2016DataGridViewTextBoxColumn";
            this.sales2016DataGridViewTextBoxColumn.ReadOnly = true;
            this.sales2016DataGridViewTextBoxColumn.Width = 125;
            // 
            // sales2017DataGridViewTextBoxColumn
            // 
            this.sales2017DataGridViewTextBoxColumn.DataPropertyName = "Sales_2017";
            this.sales2017DataGridViewTextBoxColumn.HeaderText = "Sales_2017";
            this.sales2017DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sales2017DataGridViewTextBoxColumn.Name = "sales2017DataGridViewTextBoxColumn";
            this.sales2017DataGridViewTextBoxColumn.ReadOnly = true;
            this.sales2017DataGridViewTextBoxColumn.Width = 125;
            // 
            // sales2018DataGridViewTextBoxColumn
            // 
            this.sales2018DataGridViewTextBoxColumn.DataPropertyName = "Sales_2018";
            this.sales2018DataGridViewTextBoxColumn.HeaderText = "Sales_2018";
            this.sales2018DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sales2018DataGridViewTextBoxColumn.Name = "sales2018DataGridViewTextBoxColumn";
            this.sales2018DataGridViewTextBoxColumn.ReadOnly = true;
            this.sales2018DataGridViewTextBoxColumn.Width = 125;
            // 
            // sales2019DataGridViewTextBoxColumn
            // 
            this.sales2019DataGridViewTextBoxColumn.DataPropertyName = "Sales_2019";
            this.sales2019DataGridViewTextBoxColumn.HeaderText = "Sales_2019";
            this.sales2019DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sales2019DataGridViewTextBoxColumn.Name = "sales2019DataGridViewTextBoxColumn";
            this.sales2019DataGridViewTextBoxColumn.ReadOnly = true;
            this.sales2019DataGridViewTextBoxColumn.Width = 125;
            // 
            // producerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 668);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prodChart);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "producerForm";
            this.Text = "Producer Development";
            this.Load += new System.EventHandler(this.producerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.producerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKProductToProducerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox comboBox1;
        private SalesDatabaseDataSet salesDatabaseDataSet;
        private System.Windows.Forms.BindingSource producerBindingSource;
        private SalesDatabaseDataSetTableAdapters.ProducerTableAdapter producerTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataVisualization.Charting.Chart prodChart;
        private System.Windows.Forms.BindingSource fKProductToProducerBindingSource;
        private SalesDatabaseDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.BindingSource salesBindingSource;
        private SalesDatabaseDataSetTableAdapters.SalesTableAdapter salesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sales2014DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sales2015DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sales2016DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sales2017DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sales2018DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sales2019DataGridViewTextBoxColumn;
    }
}