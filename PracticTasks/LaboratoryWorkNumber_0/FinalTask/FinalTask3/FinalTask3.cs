// В данном упражнении я реализую выборку таблиц базы данных в ЭУ "combobox" 
// с возможностью изменения и удаления данных

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalTask3
{
    public partial class FinalTask3 : Form
    {
        public FinalTask3()
        {
            InitializeComponent();
        }

        static string connectionStringToAdventureWorks2017 =
          ConfigurationManager.ConnectionStrings["AdventureWorks2017Connection"].ConnectionString;

        //static string sqlExpressionSell = "SELECT * FROM Person.Person";


        static SqlConnection connection1 = new SqlConnection(connectionStringToAdventureWorks2017);
        ToolTip tooltip1 = new ToolTip();
               

        private void FinalTask3_Load(object sender, EventArgs e)
        {
            
            connection1.Open();
            DataTable tables = connection1.GetSchema("Tables");

            foreach (DataRow row in tables.Rows)
            {
               
                comboBox1.Items.Add(row["TABLE_SCHEMA"] + "." + row["TABLE_NAME"]);

            }
            connection1.Close();

        }
        DataSet ds = new DataSet();
        SqlDataAdapter adapter = new SqlDataAdapter();

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ds.Tables.Clear();

            adapter = new SqlDataAdapter("SELECT * FROM " + comboBox1.SelectedItem.ToString(), connection1);

            SqlCommandBuilder commands1 = new SqlCommandBuilder(adapter);


            adapter.Fill(ds, "Tab");
            dataGridView1.DataSource = ds.Tables["Tab"];

            //MessageBox.Show(comboBox1.SelectedItem.ToString());
        }


        private void button1_Click(object sender, EventArgs e)
        {
            ds.EndInit();
            adapter.Update(ds.Tables["Tab"]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ds.EndInit();
            var index = dataGridView1.CurrentRow.Index;
            ds.Tables["Tab"].Rows[index].Delete();
            adapter.Update(ds.Tables["Tab"]);
        }

        
    }
}
