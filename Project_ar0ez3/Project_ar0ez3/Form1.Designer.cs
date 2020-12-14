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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.categBtn = new System.Windows.Forms.Button();
            this.bandBtn = new System.Windows.Forms.Button();
            this.prodBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(57, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 105);
            this.button1.TabIndex = 0;
            this.button1.Text = "Product Assortment";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            this.button2.Location = new System.Drawing.Point(900, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 105);
            this.button2.TabIndex = 1;
            this.button2.Text = "Data Analysis";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // categBtn
            // 
            this.categBtn.Location = new System.Drawing.Point(900, 168);
            this.categBtn.Name = "categBtn";
            this.categBtn.Size = new System.Drawing.Size(200, 33);
            this.categBtn.TabIndex = 2;
            this.categBtn.Text = "Category";
            this.categBtn.UseVisualStyleBackColor = true;
            this.categBtn.Click += new System.EventHandler(this.categBtn_Click);
            // 
            // bandBtn
            // 
            this.bandBtn.Location = new System.Drawing.Point(900, 220);
            this.bandBtn.Name = "bandBtn";
            this.bandBtn.Size = new System.Drawing.Size(200, 33);
            this.bandBtn.TabIndex = 3;
            this.bandBtn.Text = "Brand";
            this.bandBtn.UseVisualStyleBackColor = true;
            // 
            // prodBtn
            // 
            this.prodBtn.Location = new System.Drawing.Point(900, 272);
            this.prodBtn.Name = "prodBtn";
            this.prodBtn.Size = new System.Drawing.Size(200, 30);
            this.prodBtn.TabIndex = 4;
            this.prodBtn.Text = "Producer";
            this.prodBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 681);
            this.Controls.Add(this.prodBtn);
            this.Controls.Add(this.bandBtn);
            this.Controls.Add(this.categBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button categBtn;
        private System.Windows.Forms.Button bandBtn;
        private System.Windows.Forms.Button prodBtn;
    }
}

