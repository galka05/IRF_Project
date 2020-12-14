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
    public partial class Form3 : Form
    {
        SalesDatabaseEntities context = new SalesDatabaseEntities();
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'salesDatabaseDataSet.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.salesDatabaseDataSet.Category);
            // TODO: This line of code loads data into the 'salesDatabaseDataSet.Sales' table. You can move, or remove it, as needed.
            this.salesTableAdapter.Fill(this.salesDatabaseDataSet.Sales);
           // var category = from sales in context.Sales
                          // join product in context.Products on product.salesPk equals sales.id
                         //  join category in context.Categories on product.categoryPk equals category.id
           }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String idString = this.comboBox1.SelectedItem.ToString();
            Console.WriteLine(idString);
           
            int selectedID = this.comboBox1.SelectedIndex;
            var salesData = from sales in context.Sales
                            join product in context.Products on sales.ProductFK equals product.ProductID
                            //join category in context.Categories on product.CategoryFK equals category.CategoryID
                            where product.CategoryFK == selectedID
                            select new
                            {
                                sales14 = sales.Sales_2014,
                                sales15 = sales.Sales_2015,
                                sales16 = sales.Sales_2016,
                                sales17 = sales.Sales_2017,
                                sales18 = sales.Sales_2018,
                                sales19 = sales.Sales_2019,
                           
                            }; 
            this.dataGridView1.DataSource = salesData.ToList();
        }
    }
}
