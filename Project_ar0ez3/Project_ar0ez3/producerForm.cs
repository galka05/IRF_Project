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
    public partial class producerForm : Form
    {
        public producerForm()
        {
            InitializeComponent();
        }

        private void producerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'salesDatabaseDataSet.Producer' table. You can move, or remove it, as needed.
            this.producerTableAdapter.Fill(this.salesDatabaseDataSet.Producer);

        }
    }
}
