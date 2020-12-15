using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

           // chart1.ChartAreas[0].AxisX.Minimum = 0;
           // chart1.ChartAreas[0].AxisX.Maximum = 2000000000;

         

          //  var year2014 = chart1.Series.Add(“2014”);
            //var year2015 = chart1.Series.Add(“2015”);

            //year2014.Points.AddXY(“Sales”, Convert.ToDouble(label2014.Text));
           // year2015.Points.AddXY(“Sales”, Convert.ToDouble(label2015.Text));

            //string[] xYears = { "2014", "2015", "2016", "2017", "2018", "2019" };

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

           ///var series = chart1.Series[0];
           //series.XValueMember = "Year";
           // series.YValueMembers = "Sales";
           //double[] yValues =                
           // { 
           //    Convert.ToDouble(label2014.Text), 
           //    Convert.ToDouble(label2015.Text), 
           //    Convert.ToDouble(label2016.Text), 
           //    Convert.ToDouble(label2017.Text), 
           //    Convert.ToDouble(label2018.Text), 
           //    Convert.ToDouble(label2019.Text), 
           // };

            
        }

        private void Form3_Shown(object sender, EventArgs e)
        {
            //chart1.ChartAreas[0].AxisX.Minimum = 2013;
            //chart1.ChartAreas[0].AxisX.Maximum = 2020;

          


            //Series S1 = new Series();
            //S1.Points.AddXY(Convert.ToDouble(label2014.Text), 2014);
            //S1.Points.AddXY(Convert.ToDouble(label2015.Text), 2015);
            //S1.Points.AddXY(Convert.ToDouble(label2016.Text), 2016);
            //S1.Points.AddXY(Convert.ToDouble(label2017.Text), 2017);
            //S1.Points.AddXY(Convert.ToDouble(label2018.Text), 2018);
            //S1.Points.AddXY(Convert.ToDouble(label2019.Text), 2019);

            //chart1.Series[0].Points[0].AxisLabel = "2014";
            //chart1.Series[0].Points[1].AxisLabel = "2015";
            //chart1.Series[0].Points[2].AxisLabel = "2016";
            //chart1.Series[0].Points[2].AxisLabel = "2017";
            //chart1.Series[0].Points[2].AxisLabel = "2018";
            //chart1.Series[0].Points[2].AxisLabel = "2019";
        }
    }



}
