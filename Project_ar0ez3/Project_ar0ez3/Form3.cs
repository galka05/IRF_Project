using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.DataVisualization.Charting;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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
                                sales2014 = sales.Sales_2014,
                                sales2015 = sales.Sales_2015,
                                sales2016 = sales.Sales_2016,
                                sales2017 = sales.Sales_2017,
                                sales2018 = sales.Sales_2018,
                                sales2019 = sales.Sales_2019,
                           
                            }; 
            this.dataGridView1.DataSource = salesData.ToList();
           
            
            label2014.Text= (from DataGridViewRow row in dataGridView1.Rows 
                             where row.Cells[0].FormattedValue.ToString()!= string.Empty
                             select Convert.ToInt32(row.Cells[0].FormattedValue)).Sum().ToString();

            label2015.Text = (from DataGridViewRow row in dataGridView1.Rows
                              where row.Cells[1].FormattedValue.ToString() != string.Empty
                              select Convert.ToInt32(row.Cells[1].FormattedValue)).Sum().ToString();

            label2016.Text = (from DataGridViewRow row in dataGridView1.Rows
                              where row.Cells[2].FormattedValue.ToString() != string.Empty
                              select Convert.ToInt32(row.Cells[2].FormattedValue)).Sum().ToString();

            label2017.Text = (from DataGridViewRow row in dataGridView1.Rows
                              where row.Cells[3].FormattedValue.ToString() != string.Empty
                              select Convert.ToInt32(row.Cells[3].FormattedValue)).Sum().ToString();

            label2018.Text = (from DataGridViewRow row in dataGridView1.Rows
                              where row.Cells[4].FormattedValue.ToString() != string.Empty
                              select Convert.ToInt32(row.Cells[4].FormattedValue)).Sum().ToString();

            label2019.Text = (from DataGridViewRow row in dataGridView1.Rows
                              where row.Cells[5].FormattedValue.ToString() != string.Empty
                              select Convert.ToInt32(row.Cells[5].FormattedValue)).Sum().ToString();

            var series = chart1.Series[0];
            series.XValueMember = "Year";
            series.YValueMembers = "Sales";
            double[] yValues =                
            { 
                Convert.ToDouble(label2014.Text), 
                Convert.ToDouble(label2015.Text), 
                Convert.ToDouble(label2016.Text), 
                Convert.ToDouble(label2017.Text), 
                Convert.ToDouble(label2018.Text), 
                Convert.ToDouble(label2019.Text), 
            };

            string[] xYears = { "2014", "2015", "2016", "2017", "2018", "2019" };
           
           
        }

        
    }
}
