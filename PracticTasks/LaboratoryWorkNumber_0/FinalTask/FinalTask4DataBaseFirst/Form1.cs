using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
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
           
            var cities = from d in adwenturecontext.Addresses.Distinct()
                         orderby d.City
                         select d;
            

            try
            {
                listBox1.DataSource = cities.ToList();
                listBox1.DisplayMember = "City";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            Address city = (Address)listBox1.SelectedItem;
            string name = city.City;
            //MessageBox.Show(name);

            var people = from a in adwenturecontext.Addresses
                         select a;
                         //join b in adwenturecontext.BusinessEntityAddresses
                         //on a.AddressID equals b.AddressID
                         //join c in adwenturecontext.BusinessEntities
                         //on b.BusinessEntityID equals c.BusinessEntityID
                         //join d in adwenturecontext.Person
                         //on c.BusinessEntityID equals d.BusinessEntityID
                         //select d.FirstName + " " + d.MiddleName + " " + d.LastName + ": " + a.City;

            try
            {
                listBox1.DataSource = people.ToList();
                listBox1.DisplayMember = "AddressLine1";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
