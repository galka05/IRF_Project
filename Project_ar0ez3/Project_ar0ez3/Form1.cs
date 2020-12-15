using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_ar0ez3
{
    public partial class Form1 : Form
    {
        bool isVisible = false;
        public Form1()
        {
            InitializeComponent();
            brandBtn.Visible = false;
            categBtn.Visible = false;
            prodBtn.Visible = false;
            dataGridView1.Visible = false;
            textBoxEAN.Visible = false;
            labelEAN.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.isVisible = !this.isVisible;
            dataGridView1.Visible = this.isVisible;
            textBoxEAN.Visible = this.isVisible;
            labelEAN.Visible = this.isVisible;
            FilterEan();
        }

        private void FilterEan()
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.isVisible = !this.isVisible;
            brandBtn.Visible = this.isVisible;
            categBtn.Visible = this.isVisible;
            prodBtn.Visible = this.isVisible;
            

        }

        private void categBtn_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'salesDatabaseDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.salesDatabaseDataSet.Product);
            // TODO: This line of code loads data into the 'salesDatabaseDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.salesDatabaseDataSet.Product);
                      
        }

        private void prodBtn_Click(object sender, EventArgs e)
        {
            producerForm prodform = new producerForm();
            prodform.Show();
        }

        private void bandBtn_Click(object sender, EventArgs e)
        {
            brandForm brndForm = new brandForm();
            brndForm.Show();
        }
    }
}
