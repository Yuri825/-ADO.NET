using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace FinalTask2
{
    public partial class Task2 : Form
    {
        public Task2()
        {
            InitializeComponent();
        }

        static string connectionString = 
            ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        static string sqlExpression = "SELECT * FROM Customer";
        static SqlConnection connection = new SqlConnection(connectionString);

        // Создаем объект DataAdapter
        static SqlDataAdapter adapter = new SqlDataAdapter(sqlExpression, connection);

        DataSet ds = new DataSet();

        SqlCommandBuilder commands = new SqlCommandBuilder(adapter);


        private void button2_Click(object sender, EventArgs e)
        {
            ds.EndInit();
            adapter.Update(ds.Tables["Customers"]);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //dataGridView1.Rows.Clear();

            adapter.Fill(ds, "Customers");
            dataGridView1.DataSource = ds.Tables["Customers"];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ds.EndInit(); 
            var index = dataGridView1.CurrentRow.Index; 
            ds.Tables["Customers"].Rows[index].Delete();
            adapter.Update(ds.Tables["Customers"]);
        }
    }
}
