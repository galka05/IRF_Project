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
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryFKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producerFKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandFKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productdescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesDatabaseDataSet = new Project_ar0ez3.SalesDatabaseDataSet();
            this.productTableAdapter = new Project_ar0ez3.SalesDatabaseDataSetTableAdapters.ProductTableAdapter();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brandTableAdapter = new Project_ar0ez3.SalesDatabaseDataSetTableAdapters.BrandTableAdapter();
            this.producerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brandBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.categoryTableAdapter = new Project_ar0ez3.SalesDatabaseDataSetTableAdapters.CategoryTableAdapter();
            this.fKSalesToProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesTableAdapter = new Project_ar0ez3.SalesDatabaseDataSetTableAdapters.SalesTableAdapter();
            this.producerTableAdapter = new Project_ar0ez3.SalesDatabaseDataSetTableAdapters.ProducerTableAdapter();
            this.fKProductToBrandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKProductToBrandBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.producerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKSalesToProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKProductToBrandBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKProductToBrandBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.categoryFKDataGridViewTextBoxColumn,
            this.producerFKDataGridViewTextBoxColumn,
            this.brandFKDataGridViewTextBoxColumn,
            this.eANDataGridViewTextBoxColumn,
            this.productdescriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(34, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(648, 465);
            this.dataGridView1.TabIndex = 0;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.productIDDataGridViewTextBoxColumn.Visible = false;
            this.productIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // categoryFKDataGridViewTextBoxColumn
            // 
            this.categoryFKDataGridViewTextBoxColumn.DataPropertyName = "CategoryFK";
            this.categoryFKDataGridViewTextBoxColumn.HeaderText = "CategoryFK";
            this.categoryFKDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categoryFKDataGridViewTextBoxColumn.Name = "categoryFKDataGridViewTextBoxColumn";
            this.categoryFKDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoryFKDataGridViewTextBoxColumn.Visible = false;
            // 
            // producerFKDataGridViewTextBoxColumn
            // 
            this.producerFKDataGridViewTextBoxColumn.DataPropertyName = "ProducerFK";
            this.producerFKDataGridViewTextBoxColumn.HeaderText = "ProducerFK";
            this.producerFKDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.producerFKDataGridViewTextBoxColumn.Name = "producerFKDataGridViewTextBoxColumn";
            this.producerFKDataGridViewTextBoxColumn.ReadOnly = true;
            this.producerFKDataGridViewTextBoxColumn.Visible = false;
            // 
            // brandFKDataGridViewTextBoxColumn
            // 
            this.brandFKDataGridViewTextBoxColumn.DataPropertyName = "BrandFK";
            this.brandFKDataGridViewTextBoxColumn.HeaderText = "BrandFK";
            this.brandFKDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.brandFKDataGridViewTextBoxColumn.Name = "brandFKDataGridViewTextBoxColumn";
            this.brandFKDataGridViewTextBoxColumn.ReadOnly = true;
            this.brandFKDataGridViewTextBoxColumn.Visible = false;
            // 
            // eANDataGridViewTextBoxColumn
            // 
            this.eANDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.eANDataGridViewTextBoxColumn.DataPropertyName = "EAN";
            this.eANDataGridViewTextBoxColumn.FillWeight = 193.5829F;
            this.eANDataGridViewTextBoxColumn.HeaderText = "EAN";
            this.eANDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eANDataGridViewTextBoxColumn.Name = "eANDataGridViewTextBoxColumn";
            this.eANDataGridViewTextBoxColumn.ReadOnly = true;
            this.eANDataGridViewTextBoxColumn.Width = 65;
            // 
            // productdescriptionDataGridViewTextBoxColumn
            // 
            this.productdescriptionDataGridViewTextBoxColumn.DataPropertyName = "Product_description";
            this.productdescriptionDataGridViewTextBoxColumn.FillWeight = 6.417114F;
            this.productdescriptionDataGridViewTextBoxColumn.HeaderText = "Product_description";
            this.productdescriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productdescriptionDataGridViewTextBoxColumn.Name = "productdescriptionDataGridViewTextBoxColumn";
            this.productdescriptionDataGridViewTextBoxColumn.ReadOnly = true;
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
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.salesDatabaseDataSet;
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
            // producerBindingSource
            // 
            this.producerBindingSource.DataMember = "Producer";
            this.producerBindingSource.DataSource = this.salesDatabaseDataSet;
            // 
            // brandBindingSource1
            // 
            this.brandBindingSource1.DataMember = "Brand";
            this.brandBindingSource1.DataSource = this.salesDatabaseDataSet;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Category";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.categoryBindingSource;
            this.comboBox1.DisplayMember = "Category_name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(121, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 571);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.producerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKSalesToProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKProductToBrandBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKProductToBrandBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SalesDatabaseDataSet salesDatabaseDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private SalesDatabaseDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.BindingSource brandBindingSource;
        private SalesDatabaseDataSetTableAdapters.BrandTableAdapter brandTableAdapter;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private SalesDatabaseDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.BindingSource fKSalesToProductBindingSource;
        private SalesDatabaseDataSetTableAdapters.SalesTableAdapter salesTableAdapter;
        private System.Windows.Forms.BindingSource producerBindingSource;
        private SalesDatabaseDataSetTableAdapters.ProducerTableAdapter producerTableAdapter;
        private System.Windows.Forms.BindingSource brandBindingSource1;
        private System.Windows.Forms.BindingSource fKProductToBrandBindingSource;
        private System.Windows.Forms.BindingSource fKProductToBrandBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryFKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn producerFKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandFKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productdescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}