namespace Project_ar0ez3
{
    partial class brandForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.salesDatabaseDataSet = new Project_ar0ez3.SalesDatabaseDataSet();
            this.brandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brandTableAdapter = new Project_ar0ez3.SalesDatabaseDataSetTableAdapters.BrandTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 451);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(215, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(310, 121);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Sales";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(850, 550);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1003, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 23);
            this.label6.TabIndex = 20;
            this.label6.Text = "2019";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(863, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 23);
            this.label5.TabIndex = 19;
            this.label5.Text = "2018";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(723, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 23);
            this.label4.TabIndex = 18;
            this.label4.Text = "2017";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(573, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 23);
            this.label3.TabIndex = 17;
            this.label3.Text = "2016";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(423, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "2015";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(283, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "2014";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.brandBindingSource;
            this.comboBox1.DisplayMember = "Brand_name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(50, 65);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 24);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.ValueMember = "BrandID";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // salesDatabaseDataSet
            // 
            this.salesDatabaseDataSet.DataSetName = "SalesDatabaseDataSet";
            this.salesDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // brandBindingSource
            // 
            this.brandBindingSource.DataMember = "Brand";
            this.brandBindingSource.DataSource = this.salesDatabaseDataSet;
            // 
            // brandTableAdapter
            // 
            this.brandTableAdapter.ClearBeforeFill = true;
            // 
            // brandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 683);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "brandForm";
            this.Text = "Brand Development";
            this.Load += new System.EventHandler(this.brandForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private SalesDatabaseDataSet salesDatabaseDataSet;
        private System.Windows.Forms.BindingSource brandBindingSource;
        private SalesDatabaseDataSetTableAdapters.BrandTableAdapter brandTableAdapter;
    }
}