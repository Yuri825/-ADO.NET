﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQsqlSproc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Northwnd db = 
            new Northwnd(   @"Data Source=(LocalDB)\MSSQLLocalDB;
                            AttachDbFilename=D:\ИТМО\Технология ADO.NET\Базы\Northwind.mdf;
                            Integrated Security=True;
                            Connect Timeout=30"
                        );

        private void button1_Click(object sender, EventArgs e)
        {
            string param = textBox1.Text;

           var custquery = db.CustOrdersDetail(Convert.ToInt32(param));

            string msg = "";
            foreach (CustOrdersDetailResult custOrdersDetail in custquery)
            {
                msg = msg + custOrdersDetail.ProductName + "\n";
            }
            if (msg == "")
                msg = "No results.";
            MessageBox.Show(msg);

            param = "";
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string param = textBox2.Text;
            var custquery = db.CustOrderHist(param);
            string msg = "";
            foreach (CustOrderHistResult custOrdHist in custquery)
            {
                msg = msg + custOrdHist.ProductName + "\n";
            }
            MessageBox.Show(msg);
            param = "";
            textBox2.Text = "";

        }
    }
}
