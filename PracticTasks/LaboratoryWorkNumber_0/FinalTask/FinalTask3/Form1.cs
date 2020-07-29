


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalTask3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private BasaForFinalTaskEntities schoolContext;

        private void Form1_Load(object sender, EventArgs e)
        {
            schoolContext = new BasaForFinalTaskEntities();

            var departments = from d in schoolContext.Products
                              select d;

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = schoolContext.Products.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = schoolContext.Sells.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = schoolContext.Customers.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
