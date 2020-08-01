// В данном задании мы реализуем получение данных из базы данных в набор данных "DataSet" 
// с помощью объекта "DataAdapter". Таким образом мы реализуем возможность получения и 
// изменения данных

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

        static string connectionStringToAdventureWorks2017 =
           ConfigurationManager.ConnectionStrings["AdventureWorks2017Connection"].ConnectionString;

        static string sqlExpression = "SELECT * FROM Customer";
        static string sqlExpressionSell = "SELECT* FROM [Person].[Address]";

        static SqlConnection connection = new SqlConnection(connectionString);

        static SqlConnection connection1 = new SqlConnection(connectionStringToAdventureWorks2017);

        // Создаем объект DataAdapter
        static SqlDataAdapter adapter = new SqlDataAdapter(sqlExpression, connection);

        static SqlDataAdapter adapter1 = new SqlDataAdapter(sqlExpressionSell, connection1);

        DataSet ds = new DataSet();
      

        SqlCommandBuilder commands = new SqlCommandBuilder(adapter);

        SqlCommandBuilder commands1 = new SqlCommandBuilder(adapter1);

        // Сохранить данные
        private void button2_Click(object sender, EventArgs e)
        {
            ds.EndInit();
            adapter.Update(ds.Tables["Customers"]);
        }

        // Вывести таблицу на экран
        private void button1_Click_1(object sender, EventArgs e)
        {
            //dataGridView1.Rows.Clear();

            adapter.Fill(ds, "Customers");
            dataGridView1.DataSource = ds.Tables["Customers"];
        }


        // Удалить выбранную строку
        private void button3_Click(object sender, EventArgs e)
        {
            ds.EndInit(); 
            var index = dataGridView1.CurrentRow.Index; 
            ds.Tables["Customers"].Rows[index].Delete();
            adapter.Update(ds.Tables["Customers"]);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            adapter1.Fill(ds, "Addresses");
            dataGridView1.DataSource = ds.Tables["Addresses"];

        }

        private void button6_Click(object sender, EventArgs e)
        {
            ds.EndInit();
            adapter1.Update(ds.Tables["Addresses"]);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ds.EndInit();
            var index = dataGridView1.CurrentRow.Index;
            ds.Tables["Addresses"].Rows[index].Delete();
            adapter1.Update(ds.Tables["Addresses"]);
        }
    }
}
