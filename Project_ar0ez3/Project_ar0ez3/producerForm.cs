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
    public partial class producerForm : Form
    {
        SalesDatabaseEntities context = new SalesDatabaseEntities();
        CalculateLabel clabel2014 = new CalculateLabel();
        CalculateLabel clabel2015 = new CalculateLabel();
        CalculateLabel clabel2016 = new CalculateLabel();
        CalculateLabel clabel2017 = new CalculateLabel();
        CalculateLabel clabel2018 = new CalculateLabel();
        CalculateLabel clabel2019 = new CalculateLabel();
        public producerForm()
        {
            InitializeComponent();
        }     

        private void producerForm_Load(object sender, EventArgs e)
        {
            this.clabel2014.Top = 60;
            this.clabel2014.Left = 200;
            this.clabel2015.Top = 60;
            this.clabel2015.Left = 310;
            this.clabel2016.Top = 60;
            this.clabel2016.Left = 420;
            this.clabel2017.Top = 60;
            this.clabel2017.Left = 530;
            this.clabel2018.Top = 60;
            this.clabel2018.Left = 640;
            this.clabel2019.Top = 60;
            this.clabel2019.Left = 750;

            this.Controls.Add(this.clabel2014);
            this.Controls.Add(this.clabel2015);
            this.Controls.Add(this.clabel2016);
            this.Controls.Add(this.clabel2017);
            this.Controls.Add(this.clabel2018);
            this.Controls.Add(this.clabel2019);

            // TODO: This line of code loads data into the 'salesDatabaseDataSet.Category' table. You can move, or remove it, as needed.
            this.producerTableAdapter.Fill(this.salesDatabaseDataSet.Producer);
            // TODO: This line of code loads data into the 'salesDatabaseDataSet.Sales' table. You can move, or remove it, as needed.
            this.salesTableAdapter.Fill(this.salesDatabaseDataSet.Sales);

            prodChart.Visible = Visible;

            getSalesData();
            countInLabels();
            drawChart();
        }

        private void drawChart()
        {
            Series s = prodChart.Series[0];
            s.Points.Clear();
            s.Points.AddXY(2014, Convert.ToInt32(clabel2014.Text));
            s.Points.AddXY(2015, Convert.ToInt32(clabel2015.Text));
            s.Points.AddXY(2016, Convert.ToInt32(clabel2016.Text));
            s.Points.AddXY(2017, Convert.ToInt32(clabel2017.Text));
            s.Points.AddXY(2018, Convert.ToInt32(clabel2018.Text));
            s.Points.AddXY(2019, Convert.ToInt32(clabel2019.Text));
            prodChart.Visible = true;
        }

        private void countInLabels()
        {
            this.clabel2014.Text = (from DataGridViewRow row in dataGridView1.Rows
                                    where row.Cells[0].FormattedValue.ToString() != string.Empty
                                    select Convert.ToInt32(row.Cells[0].FormattedValue)).Sum().ToString();
            this.clabel2015.Text = (from DataGridViewRow row in dataGridView1.Rows
                                    where row.Cells[0].FormattedValue.ToString() != string.Empty
                                    select Convert.ToInt32(row.Cells[0].FormattedValue)).Sum().ToString();
            this.clabel2016.Text = (from DataGridViewRow row in dataGridView1.Rows
                                    where row.Cells[0].FormattedValue.ToString() != string.Empty
                                    select Convert.ToInt32(row.Cells[0].FormattedValue)).Sum().ToString();
            this.clabel2017.Text = (from DataGridViewRow row in dataGridView1.Rows
                                    where row.Cells[0].FormattedValue.ToString() != string.Empty
                                    select Convert.ToInt32(row.Cells[0].FormattedValue)).Sum().ToString();
            this.clabel2018.Text = (from DataGridViewRow row in dataGridView1.Rows
                                    where row.Cells[0].FormattedValue.ToString() != string.Empty
                                    select Convert.ToInt32(row.Cells[0].FormattedValue)).Sum().ToString();
            this.clabel2019.Text = (from DataGridViewRow row in dataGridView1.Rows
                                    where row.Cells[0].FormattedValue.ToString() != string.Empty
                                    select Convert.ToInt32(row.Cells[0].FormattedValue)).Sum().ToString();
        }

        private void getSalesData()
        {
            int selectedID = this.comboBox1.SelectedIndex;
            var salesData = from sales in context.Sales
                            join product in context.Products on sales.ProductFK equals product.ProductID
                            where product.ProducerFK == (selectedID + 1)
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
