namespace Project_ar0ez3
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.categBtn = new System.Windows.Forms.Button();
            this.brandBtn = new System.Windows.Forms.Button();
            this.prodBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesDatabaseDataSet = new Project_ar0ez3.SalesDatabaseDataSet();
            this.productTableAdapter = new Project_ar0ez3.SalesDatabaseDataSetTableAdapters.ProductTableAdapter();
            this.eANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productdescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(658, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(446, 105);
            this.button1.TabIndex = 0;
            this.button1.Text = "Product Assortment";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(104, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(417, 107);
            this.button2.TabIndex = 1;
            this.button2.Text = "Data Analysis";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // categBtn
            // 
            this.categBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.categBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.categBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categBtn.Location = new System.Drawing.Point(141, 209);
            this.categBtn.Name = "categBtn";
            this.categBtn.Size = new System.Drawing.Size(350, 70);
            this.categBtn.TabIndex = 2;
            this.categBtn.Text = "Category";
            this.categBtn.UseVisualStyleBackColor = false;
            this.categBtn.Click += new System.EventHandler(this.categBtn_Click);
            // 
            // brandBtn
            // 
            this.brandBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.brandBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.brandBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandBtn.Location = new System.Drawing.Point(141, 475);
            this.brandBtn.Name = "brandBtn";
            this.brandBtn.Size = new System.Drawing.Size(350, 70);
            this.brandBtn.TabIndex = 3;
            this.brandBtn.Text = "Brand";
            this.brandBtn.UseVisualStyleBackColor = false;
            this.brandBtn.Click += new System.EventHandler(this.bandBtn_Click);
            // 
            // prodBtn
            // 
            this.prodBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.prodBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.prodBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodBtn.Location = new System.Drawing.Point(141, 346);
            this.prodBtn.Name = "prodBtn";
            this.prodBtn.Size = new System.Drawing.Size(350, 70);
            this.prodBtn.TabIndex = 4;
            this.prodBtn.Text = "Producer";
            this.prodBtn.UseVisualStyleBackColor = false;
            this.prodBtn.Click += new System.EventHandler(this.prodBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eANDataGridViewTextBoxColumn,
            this.productdescriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(602, 209);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(555, 336);
            this.dataGridView1.TabIndex = 5;
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
            // eANDataGridViewTextBoxColumn
            // 
            this.eANDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.eANDataGridViewTextBoxColumn.DataPropertyName = "EAN";
            this.eANDataGridViewTextBoxColumn.HeaderText = "EAN code";
            this.eANDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eANDataGridViewTextBoxColumn.Name = "eANDataGridViewTextBoxColumn";
            this.eANDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productdescriptionDataGridViewTextBoxColumn
            // 
            this.productdescriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productdescriptionDataGridViewTextBoxColumn.DataPropertyName = "Product_description";
            this.productdescriptionDataGridViewTextBoxColumn.HeaderText = "Product Description";
            this.productdescriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productdescriptionDataGridViewTextBoxColumn.Name = "productdescriptionDataGridViewTextBoxColumn";
            this.productdescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Project_ar0ez3.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.prodBtn);
            this.Controls.Add(this.brandBtn);
            this.Controls.Add(this.categBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button categBtn;
        private System.Windows.Forms.Button brandBtn;
        private System.Windows.Forms.Button prodBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SalesDatabaseDataSet salesDatabaseDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private SalesDatabaseDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn eANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productdescriptionDataGridViewTextBoxColumn;
    }
}

