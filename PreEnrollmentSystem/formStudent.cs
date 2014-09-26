using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PreEnrollmentSystem
{
    public partial class FormStudent : Form
    {
        public FormStudent()
        {
            InitializeComponent();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonSchedule_Click(object sender, EventArgs e)
        {
            panelSchedule.BringToFront();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            panelHome.BringToFront();
        }

        private void buttonGrades_Click(object sender, EventArgs e)
        {
            panelGrades.BringToFront();
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            panelStudentProfile.BringToFront();
        }

        private void formStudent_Load(object sender, EventArgs e)
        {
            comboBox1.Text=("2013-2014");
            comboBox1.Items.Add("2013-2014");
            comboBox1.Items.Add("2014-2015");
            comboBox1.Items.Add("2015-2016");
            comboBox2.Text = ("1st Term");
            comboBox2.Items.Add("1st Term");
            comboBox2.Items.Add("2nd Term");
        }

        public void loadData(String username)
        {
            // TODO: This line of code loads data into the 'enrollmentDataSet.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.FillStudentData(this.enrollmentDataSet.Students, username);
            labelName.Text = this.studentsTableAdapter.getName(username);
        }
    }
}
