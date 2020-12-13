namespace Project_ar0ez3
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesDatabaseDataSet = new Project_ar0ez3.SalesDatabaseDataSet();
            this.productTableAdapter = new Project_ar0ez3.SalesDatabaseDataSetTableAdapters.ProductTableAdapter();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryFKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producerFKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandFKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productdescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.brandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brandTableAdapter = new Project_ar0ez3.SalesDatabaseDataSetTableAdapters.BrandTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryTableAdapter = new Project_ar0ez3.SalesDatabaseDataSetTableAdapters.CategoryTableAdapter();
            this.fKSalesToProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesTableAdapter = new Project_ar0ez3.SalesDatabaseDataSetTableAdapters.SalesTableAdapter();
            this.producerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.producerTableAdapter = new Project_ar0ez3.SalesDatabaseDataSetTableAdapters.ProducerTableAdapter();
            this.fKProductToBrandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKProductToBrandBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.brandBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKSalesToProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.producerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKProductToBrandBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKProductToBrandBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.categoryFKDataGridViewTextBoxColumn,
            this.producerFKDataGridViewTextBoxColumn,
            this.brandFKDataGridViewTextBoxColumn,
            this.eANDataGridViewTextBoxColumn,
            this.productdescriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(434, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(603, 515);
            this.dataGridView1.TabIndex = 0;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.salesDatabaseDataSet;
            // 
            // salesDatabaseDataSet
            // 
            this.salesDatabaseDataSet.DataSetName = "SalesDatabaseDataSet";
            this.salesDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.Visible = false;
            this.productIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // categoryFKDataGridViewTextBoxColumn
            // 
            this.categoryFKDataGridViewTextBoxColumn.DataPropertyName = "CategoryFK";
            this.categoryFKDataGridViewTextBoxColumn.HeaderText = "CategoryFK";
            this.categoryFKDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categoryFKDataGridViewTextBoxColumn.Name = "categoryFKDataGridViewTextBoxColumn";
            this.categoryFKDataGridViewTextBoxColumn.Visible = false;
            this.categoryFKDataGridViewTextBoxColumn.Width = 125;
            // 
            // producerFKDataGridViewTextBoxColumn
            // 
            this.producerFKDataGridViewTextBoxColumn.DataPropertyName = "ProducerFK";
            this.producerFKDataGridViewTextBoxColumn.HeaderText = "ProducerFK";
            this.producerFKDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.producerFKDataGridViewTextBoxColumn.Name = "producerFKDataGridViewTextBoxColumn";
            this.producerFKDataGridViewTextBoxColumn.Visible = false;
            this.producerFKDataGridViewTextBoxColumn.Width = 125;
            // 
            // brandFKDataGridViewTextBoxColumn
            // 
            this.brandFKDataGridViewTextBoxColumn.DataPropertyName = "BrandFK";
            this.brandFKDataGridViewTextBoxColumn.HeaderText = "BrandFK";
            this.brandFKDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.brandFKDataGridViewTextBoxColumn.Name = "brandFKDataGridViewTextBoxColumn";
            this.brandFKDataGridViewTextBoxColumn.Visible = false;
            this.brandFKDataGridViewTextBoxColumn.Width = 125;
            // 
            // eANDataGridViewTextBoxColumn
            // 
            this.eANDataGridViewTextBoxColumn.DataPropertyName = "EAN";
            this.eANDataGridViewTextBoxColumn.HeaderText = "EAN";
            this.eANDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eANDataGridViewTextBoxColumn.Name = "eANDataGridViewTextBoxColumn";
            this.eANDataGridViewTextBoxColumn.Width = 125;
            // 
            // productdescriptionDataGridViewTextBoxColumn
            // 
            this.productdescriptionDataGridViewTextBoxColumn.DataPropertyName = "Product_description";
            this.productdescriptionDataGridViewTextBoxColumn.HeaderText = "Product_description";
            this.productdescriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productdescriptionDataGridViewTextBoxColumn.Name = "productdescriptionDataGridViewTextBoxColumn";
            this.productdescriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.categoryBindingSource;
            this.comboBox1.DisplayMember = "Category_name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(168, 75);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 24);
            this.comboBox1.TabIndex = 1;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Producer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Brand";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.producerBindingSource;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(168, 122);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(168, 24);
            this.comboBox2.TabIndex = 5;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.brandBindingSource1;
            this.comboBox3.DisplayMember = "Brand_name";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(168, 182);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(168, 24);
            this.comboBox3.TabIndex = 6;
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
            // fKSalesToProductBindingSource
            // 
            this.fKSalesToProductBindingSource.DataMember = "FK_Sales_ToProduct";
            this.fKSalesToProductBindingSource.DataSource = this.productBindingSource;
            // 
            // salesTableAdapter
            // 
            this.salesTableAdapter.ClearBeforeFill = true;
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
            // fKProductToBrandBindingSource
            // 
            this.fKProductToBrandBindingSource.DataMember = "FK_Product_ToBrand";
            this.fKProductToBrandBindingSource.DataSource = this.brandBindingSource;
            // 
            // fKProductToBrandBindingSource1
            // 
            this.fKProductToBrandBindingSource1.DataMember = "FK_Product_ToBrand";
            this.fKProductToBrandBindingSource1.DataSource = this.brandBindingSource;
            // 
            // brandBindingSource1
            // 
            this.brandBindingSource1.DataMember = "Brand";
            this.brandBindingSource1.DataSource = this.salesDatabaseDataSet;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 571);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKSalesToProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.producerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKProductToBrandBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKProductToBrandBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SalesDatabaseDataSet salesDatabaseDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private SalesDatabaseDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryFKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn producerFKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandFKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productdescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource brandBindingSource;
        private SalesDatabaseDataSetTableAdapters.BrandTableAdapter brandTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private SalesDatabaseDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.BindingSource fKSalesToProductBindingSource;
        private SalesDatabaseDataSetTableAdapters.SalesTableAdapter salesTableAdapter;
        private System.Windows.Forms.BindingSource producerBindingSource;
        private SalesDatabaseDataSetTableAdapters.ProducerTableAdapter producerTableAdapter;
        private System.Windows.Forms.BindingSource brandBindingSource1;
        private System.Windows.Forms.BindingSource fKProductToBrandBindingSource;
        private System.Windows.Forms.BindingSource fKProductToBrandBindingSource1;
    }
}