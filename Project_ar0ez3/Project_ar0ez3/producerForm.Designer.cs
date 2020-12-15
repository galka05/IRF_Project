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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2014 = new System.Windows.Forms.Label();
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
            this.salesDatabaseDataSet = new Project_ar0ez3.SalesDatabaseDataSet();
            this.producerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.producerTableAdapter = new Project_ar0ez3.SalesDatabaseDataSetTableAdapters.ProducerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.producerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(406, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(732, 207);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Visible = false;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(406, 41);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Sales";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(732, 596);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.producerBindingSource;
            this.comboBox1.DisplayMember = "Producer_name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(42, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(292, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.ValueMember = "ProducerID";
            // 
            // label2014
            // 
            this.label2014.AutoSize = true;
            this.label2014.Location = new System.Drawing.Point(129, 354);
            this.label2014.Name = "label2014";
            this.label2014.Size = new System.Drawing.Size(46, 17);
            this.label2014.TabIndex = 4;
            this.label2014.Text = "label1";
            // 
            // label2015
            // 
            this.label2015.AutoSize = true;
            this.label2015.Location = new System.Drawing.Point(129, 392);
            this.label2015.Name = "label2015";
            this.label2015.Size = new System.Drawing.Size(46, 17);
            this.label2015.TabIndex = 5;
            this.label2015.Text = "label2";
            // 
            // label2016
            // 
            this.label2016.AutoSize = true;
            this.label2016.Location = new System.Drawing.Point(129, 441);
            this.label2016.Name = "label2016";
            this.label2016.Size = new System.Drawing.Size(46, 17);
            this.label2016.TabIndex = 6;
            this.label2016.Text = "label3";
            // 
            // label2017
            // 
            this.label2017.AutoSize = true;
            this.label2017.Location = new System.Drawing.Point(129, 481);
            this.label2017.Name = "label2017";
            this.label2017.Size = new System.Drawing.Size(46, 17);
            this.label2017.TabIndex = 7;
            this.label2017.Text = "label4";
            // 
            // label2018
            // 
            this.label2018.AutoSize = true;
            this.label2018.Location = new System.Drawing.Point(129, 523);
            this.label2018.Name = "label2018";
            this.label2018.Size = new System.Drawing.Size(46, 17);
            this.label2018.TabIndex = 8;
            this.label2018.Text = "label5";
            // 
            // label2019
            // 
            this.label2019.AutoSize = true;
            this.label2019.Location = new System.Drawing.Point(129, 567);
            this.label2019.Name = "label2019";
            this.label2019.Size = new System.Drawing.Size(46, 17);
            this.label2019.TabIndex = 9;
            this.label2019.Text = "label6";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "2014";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "2015";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 441);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "2016";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 481);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "2017";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 523);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "2018";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 567);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "2019";
            // 
            // salesDatabaseDataSet
            // 
            this.salesDatabaseDataSet.DataSetName = "SalesDatabaseDataSet";
            this.salesDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // producerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 681);
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
            this.Controls.Add(this.label2014);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "producerForm";
            this.Text = "producerForm";
            this.Load += new System.EventHandler(this.producerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.producerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox comboBox1;
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
        private SalesDatabaseDataSet salesDatabaseDataSet;
        private System.Windows.Forms.BindingSource producerBindingSource;
        private SalesDatabaseDataSetTableAdapters.ProducerTableAdapter producerTableAdapter;
    }
}