﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace CourseManager
{
    public partial class OfficeAssignment : Form
    {
        public OfficeAssignment()
        {
            InitializeComponent();
        }

        private SchoolEntities schoolContext;

        private void OfficeAssignment_Load(object sender, EventArgs e)
        {
            schoolContext = new SchoolEntities();
            var instrQuery = schoolContext.People.OfType<Instructor>();
            officeGridView.DataSource = instrQuery.ToList();
            officeGridView.Columns["HireDate"].Visible = false;
            officeGridView.Columns["Timestamp"].Visible = false;
            officeGridView.Columns["PersonID"].Visible = false;
            officeGridView.Columns["EnrollmentDate"].Visible = false;
            officeGridView.Columns["StudentGrades"].Visible = false;
            officeGridView.Columns["Courses"].Visible = false;
        }

        private void saveChanges_Click(object sender, EventArgs e)
        {
            schoolContext.SaveChanges();
            MessageBox.Show("Change(s) saved to the database.");
            Refresh();
        }

        private void saveChanges_MouseHover(object sender, EventArgs e)
        {
            saveChanges.BackColor = Color.Red;
            saveChanges.ForeColor = Color.White;
        }

        private void saveChanges_MouseLeave(object sender, EventArgs e)
        {
            saveChanges.BackColor = SystemColors.Control;
            saveChanges.ForeColor = SystemColors.ControlText;
        }
    }
}
