// В данном задании мы реализуем чтение данных непосредственно из базы данных без 
// возможности редактирования c помощью объекта DataReader. 

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

namespace FinalTask
{
    public partial class Task1 : Form
    {
        public Task1()
        {
            InitializeComponent();
        }
        static string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        string sqlExpressionProduct = "SELECT * FROM Products";
        string sqlExpressionSell = "SELECT * FROM Sell";

        private void getData_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();
                DataTable dt = new DataTable();

                SqlCommand command = new SqlCommand(sqlExpressionProduct, connection);

                SqlDataReader reader = command.ExecuteReader();

                List<string[]> data = new List<string[]>();

                dataGridView1.Rows.Add("ID", "Наименование", "Количество", "Производитель", "Цена");

                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader.GetValue(0), reader.GetValue(1),
                                            reader.GetValue(2), reader.GetValue(3),
                                            reader.GetValue(4));
                }

            }
            //MessageBox.Show("Подключение закрыто...");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();
                DataTable dt = new DataTable();

                SqlCommand command = new SqlCommand(sqlExpressionSell, connection);

                SqlDataReader reader = command.ExecuteReader();

                List<string[]> data = new List<string[]>();

                dataGridView1.Rows.Add("ID", "Наименование", "Продано", "Цена", "Сумма");
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader.GetValue(0), reader.GetValue(1),
                                            reader.GetValue(2), reader.GetValue(3),
                                            reader.GetValue(4));
                }
            }
        }
    }
    
}
