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

namespace FinalTask4CodeFirst
{
    public partial class Form1 : Form
    {
        SoccerContext db;
        public Form1()
            
        {
            InitializeComponent();

            db = new SoccerContext();
            db.Actor.Load();

            dataGridView1.DataSource = db.Actor.Local.ToBindingList();
        }

        // добавление 
        private void button1_Click(object sender, EventArgs e)
        {
            ActorsForm plForm = new ActorsForm();
            DialogResult result = plForm.ShowDialog(this);

            if (result == DialogResult.Cancel) return;

            Actors actor = new Actors();
            actor.Age = (int)plForm.numericUpDown1.Value;
            actor.Name = plForm.textBox1.Text;
            actor.Citizen = plForm.textBox2.Text;

            db.Actor.Add(actor);
            db.SaveChanges();

            MessageBox.Show("Новый актер добавлен");
        }


        // Редактирование
        private void button2_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (converted == false) return;

                Actors actor = db.Actor.Find(id);

                ActorsForm plForm = new ActorsForm();
                plForm.numericUpDown1.Value = actor.Age;
                plForm.textBox1.Text = actor.Name;
                plForm.textBox2.Text = actor.Citizen;

                DialogResult result = plForm.ShowDialog(this);

                if (result == DialogResult.Cancel) return;

                actor.Age = (int)plForm.numericUpDown1.Value;
                actor.Name = plForm.textBox1.Text;
                actor.Citizen = plForm.textBox2.Text;

                db.SaveChanges();
                dataGridView1.Refresh();
                MessageBox.Show("Обновлено");
            }
        }


        // удаление
        private void button3_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);

                if (converted == false) return;

                Actors actor = db.Actor.Find(id);
                db.Actor.Remove(actor);
                db.SaveChanges();

                MessageBox.Show("Объект удален");
            }
        }
    }
}
