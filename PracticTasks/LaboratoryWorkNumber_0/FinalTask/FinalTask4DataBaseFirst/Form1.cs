using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalTask4DataBaseFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private AdventureWorks2017Entities adwenturecontext;

        private void button1_Click(object sender, EventArgs e)
        {
            adwenturecontext = new AdventureWorks2017Entities();

            try
            {
                listBox1.DataSource = 
                    (from p in adwenturecontext.Addresses.OrderBy(k => k.City).ToList() 
                     select p.City).Distinct().ToList();

               
                listBox1.DisplayMember = "City";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            var people = from a in adwenturecontext.Addresses
                         where a.City == listBox1.SelectedItem.ToString()
                         select a;

            try
            {

                dataGridView1.DataSource = people.ToList();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            adwenturecontext = new AdventureWorks2017Entities();
           
            var people = from a in adwenturecontext.Addresses
                         where a.City == listBox1.SelectedItem.ToString()

                         join b in adwenturecontext.BusinessEntityAddresses
                         on a.AddressID equals b.AddressID

                         join c in adwenturecontext.BusinessEntities
                         on b.BusinessEntityID equals c.BusinessEntityID

                         join d in adwenturecontext.People
                         on c.BusinessEntityID equals d.BusinessEntityID

                         select d;

            try
            {

                dataGridView1.DataSource = people.ToList();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
