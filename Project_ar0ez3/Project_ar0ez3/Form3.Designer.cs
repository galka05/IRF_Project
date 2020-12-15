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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.salesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.salesDatabaseDataSet = new Project_ar0ez3.SalesDatabaseDataSet();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesTableAdapter = new Project_ar0ez3.SalesDatabaseDataSetTableAdapters.SalesTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryTableAdapter = new Project_ar0ez3.SalesDatabaseDataSetTableAdapters.CategoryTableAdapter();
            this.label2015 = new System.Windows.Forms.Label();
            this.label2016 = new System.Windows.Forms.Label();
            this.label2017 = new System.Windows.Forms.Label();
            this.label2018 = new System.Windows.Forms.Label();
            this.label2019 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
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
            this.dataGridView1.Location = new System.Drawing.Point(321, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(781, 224);
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
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(321, 266);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Sales";
            this.chart1.Series.Add(series4);
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
            // label2015
            // 
            this.label2015.AutoSize = true;
            this.label2015.BackColor = System.Drawing.Color.White;
            this.label2015.Location = new System.Drawing.Point(173, 102);
            this.label2015.Name = "label2015";
            this.label2015.Size = new System.Drawing.Size(46, 17);
            this.label2015.TabIndex = 4;
            this.label2015.Text = "label2";
            // 
            // label2016
            // 
            this.label2016.AutoSize = true;
            this.label2016.BackColor = System.Drawing.Color.White;
            this.label2016.Location = new System.Drawing.Point(173, 144);
            this.label2016.Name = "label2016";
            this.label2016.Size = new System.Drawing.Size(46, 17);
            this.label2016.TabIndex = 5;
            this.label2016.Text = "label3";
            // 
            // label2017
            // 
            this.label2017.AutoSize = true;
            this.label2017.BackColor = System.Drawing.Color.White;
            this.label2017.Location = new System.Drawing.Point(173, 183);
            this.label2017.Name = "label2017";
            this.label2017.Size = new System.Drawing.Size(46, 17);
            this.label2017.TabIndex = 6;
            this.label2017.Text = "label4";
            // 
            // label2018
            // 
            this.label2018.AutoSize = true;
            this.label2018.BackColor = System.Drawing.Color.White;
            this.label2018.Location = new System.Drawing.Point(173, 221);
            this.label2018.Name = "label2018";
            this.label2018.Size = new System.Drawing.Size(46, 17);
            this.label2018.TabIndex = 7;
            this.label2018.Text = "label5";
            // 
            // label2019
            // 
            this.label2019.AutoSize = true;
            this.label2019.BackColor = System.Drawing.Color.White;
            this.label2019.Location = new System.Drawing.Point(173, 266);
            this.label2019.Name = "label2019";
            this.label2019.Size = new System.Drawing.Size(46, 17);
            this.label2019.TabIndex = 8;
            this.label2019.Text = "label6";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "2014";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "2015";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 417);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "2016";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 456);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "2017";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 494);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "2018";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 539);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "2019";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 658);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2019);
            this.Controls.Add(this.label2018);
            this.Controls.Add(this.label2017);
            this.Controls.Add(this.label2016);
            this.Controls.Add(this.label2015);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}