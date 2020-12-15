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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.salesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.salesDatabaseDataSet = new Project_ar0ez3.SalesDatabaseDataSet();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesTableAdapter = new Project_ar0ez3.SalesDatabaseDataSetTableAdapters.SalesTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryTableAdapter = new Project_ar0ez3.SalesDatabaseDataSetTableAdapters.CategoryTableAdapter();
            this.label2014 = new System.Windows.Forms.Label();
            this.label2015 = new System.Windows.Forms.Label();
            this.label2016 = new System.Windows.Forms.Label();
            this.label2017 = new System.Windows.Forms.Label();
            this.label2018 = new System.Windows.Forms.Label();
            this.label2019 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(321, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(781, 155);
            this.dataGridView1.TabIndex = 0;
            // 
            // salesBindingSource1
            // 
            this.salesBindingSource1.DataMember = "Sales";
            this.salesBindingSource1.DataSource = this.salesDatabaseDataSet;
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
            this.chart1.Location = new System.Drawing.Point(321, 262);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Sales";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(781, 364);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
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
            // comboBox1
            // 
            this.comboBox1.DataSource = this.categoryBindingSource;
            this.comboBox1.DisplayMember = "Category_name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(27, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(259, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "CategoryID";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.salesDatabaseDataSet;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // label2014
            // 
            this.label2014.AutoSize = true;
            this.label2014.Location = new System.Drawing.Point(334, 220);
            this.label2014.Name = "label2014";
            this.label2014.Size = new System.Drawing.Size(46, 17);
            this.label2014.TabIndex = 3;
            this.label2014.Text = "label1";
            // 
            // label2015
            // 
            this.label2015.AutoSize = true;
            this.label2015.Location = new System.Drawing.Point(412, 220);
            this.label2015.Name = "label2015";
            this.label2015.Size = new System.Drawing.Size(46, 17);
            this.label2015.TabIndex = 4;
            this.label2015.Text = "label2";
            // 
            // label2016
            // 
            this.label2016.AutoSize = true;
            this.label2016.Location = new System.Drawing.Point(490, 220);
            this.label2016.Name = "label2016";
            this.label2016.Size = new System.Drawing.Size(46, 17);
            this.label2016.TabIndex = 5;
            this.label2016.Text = "label3";
            this.label2016.Visible = false;
            // 
            // label2017
            // 
            this.label2017.AutoSize = true;
            this.label2017.Location = new System.Drawing.Point(562, 220);
            this.label2017.Name = "label2017";
            this.label2017.Size = new System.Drawing.Size(46, 17);
            this.label2017.TabIndex = 6;
            this.label2017.Text = "label4";
            this.label2017.Visible = false;
            // 
            // label2018
            // 
            this.label2018.AutoSize = true;
            this.label2018.Location = new System.Drawing.Point(637, 220);
            this.label2018.Name = "label2018";
            this.label2018.Size = new System.Drawing.Size(46, 17);
            this.label2018.TabIndex = 7;
            this.label2018.Text = "label5";
            this.label2018.Visible = false;
            // 
            // label2019
            // 
            this.label2019.AutoSize = true;
            this.label2019.Location = new System.Drawing.Point(713, 220);
            this.label2019.Name = "label2019";
            this.label2019.Size = new System.Drawing.Size(46, 17);
            this.label2019.TabIndex = 8;
            this.label2019.Text = "label6";
            this.label2019.Visible = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 658);
            this.Controls.Add(this.label2019);
            this.Controls.Add(this.label2018);
            this.Controls.Add(this.label2017);
            this.Controls.Add(this.label2016);
            this.Controls.Add(this.label2015);
            this.Controls.Add(this.label2014);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private SalesDatabaseDataSet salesDatabaseDataSet;
        private System.Windows.Forms.BindingSource salesBindingSource;
        private SalesDatabaseDataSetTableAdapters.SalesTableAdapter salesTableAdapter;
        private System.Windows.Forms.BindingSource salesBindingSource1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private SalesDatabaseDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.Label label2014;
        private System.Windows.Forms.Label label2015;
        private System.Windows.Forms.Label label2016;
        private System.Windows.Forms.Label label2017;
        private System.Windows.Forms.Label label2018;
        private System.Windows.Forms.Label label2019;
    }
}