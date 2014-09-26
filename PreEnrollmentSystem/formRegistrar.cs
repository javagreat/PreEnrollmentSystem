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
    public partial class FormRegistrar : Form
    {
        public FormRegistrar()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox26.Text = DateTime.Now.ToLongTimeString();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            panelHome.BringToFront();
        }

        private void buttonCreateStudent_Click(object sender, EventArgs e)
        {
            panelCreateStudentAccount.BringToFront();
        }

        private void buttonFacultyAccount_Click(object sender, EventArgs e)
        {
            panelCreateFacultyAccount.BringToFront();
        }

        private void buttonStudentAssessment_Click(object sender, EventArgs e)
        {
            panelStudentAssessment.BringToFront();
        }

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {

        }

        private void FormRegistrar_Load(object sender, EventArgs e)
        {
        }
    }
}
