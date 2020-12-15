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
        CalculateLabel clabel2014= new CalculateLabel();
        public Form3()
        {
            InitializeComponent();

            
        }
     
        private void Form3_Load(object sender, EventArgs e)
        {
            this.clabel2014.Top = 338;
            this.clabel2014.Left = 103;

            this.Controls.Add(this.clabel2014);

            // TODO: This line of code loads data into the 'salesDatabaseDataSet.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.salesDatabaseDataSet.Category);
            // TODO: This line of code loads data into the 'salesDatabaseDataSet.Sales' table. You can move, or remove it, as needed.
            this.salesTableAdapter.Fill(this.salesDatabaseDataSet.Sales);
            
            chart1.Visible = Visible;
            
            getSalesData();

            countInLabels();

            drawChart();

            
        }

        private void countInLabels()
        {
            
            this.clabel2014.Text = (from DataGridViewRow row in dataGridView1.Rows
                              where row.Cells[0].FormattedValue.ToString() != string.Empty
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
        }

        private void drawChart()
        {
            Series s = chart1.Series[0];
            s.Points.Clear();
            s.Points.AddXY(2014, Convert.ToInt32(clabel2014.Text));
            s.Points.AddXY(2015, Convert.ToInt32(label2015.Text));
            s.Points.AddXY(2016, Convert.ToInt32(label2016.Text));
            s.Points.AddXY(2017, Convert.ToInt32(label2017.Text));
            s.Points.AddXY(2018, Convert.ToInt32(label2018.Text));
            s.Points.AddXY(2019, Convert.ToInt32(label2019.Text));
            chart1.Visible = true;
        }

        private void getSalesData()
        {
            int selectedID = this.comboBox1.SelectedIndex;
            var salesData = from sales in context.Sales
                            join product in context.Products on sales.ProductFK equals product.ProductID
                            //join category in context.Categories on product.CategoryFK equals category.CategoryID
                            where product.CategoryFK == (selectedID + 1)
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
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            getSalesData();
            countInLabels();
            drawChart();
        }


    }



}
