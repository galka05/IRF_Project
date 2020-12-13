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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'salesDatabaseDataSet.Producer' table. You can move, or remove it, as needed.
            this.producerTableAdapter.Fill(this.salesDatabaseDataSet.Producer);
            // TODO: This line of code loads data into the 'salesDatabaseDataSet.Sales' table. You can move, or remove it, as needed.
            this.salesTableAdapter.Fill(this.salesDatabaseDataSet.Sales);
            // TODO: This line of code loads data into the 'salesDatabaseDataSet.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.salesDatabaseDataSet.Category);
            // TODO: This line of code loads data into the 'salesDatabaseDataSet.Brand' table. You can move, or remove it, as needed.
            this.brandTableAdapter.Fill(this.salesDatabaseDataSet.Brand);
            // TODO: This line of code loads data into the 'salesDatabaseDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.salesDatabaseDataSet.Product);

        }
    }
}
