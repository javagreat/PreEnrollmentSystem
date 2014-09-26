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
            String lastname = textBoxStudentLastname.Text;
            String firstname = textBoxStudentFirstname.Text;
            String middlename = textBoxStudentMiddlename.Text;
            String accountname = firstname[0] + middlename[0] + lastname;

            String studentNum = "047 - 2014 - 0000";

            MessageBox.Show(accountname);

            this.studentsTableAdapter.insertStudent(accountname, lastname, firstname, middlename, studentNum,
                "Regular", comboBoxStudentGender.Text, comboBoxCourse.Text, dateTimePickerBirthdate.Text,
                textBoxStudentBirthplace.Text, textBoxStudentCitizenship.Text, 
                comboBoxStudentCivilStatus.Text, textBoxStudentReligion.Text);
        }

        private void buttonClearData_Click(object sender, EventArgs e)
        {
            textBoxStudentFirstname.Text = "";
            textBoxStudentMiddlename.Text = "";
            textBoxStudentLastname.Text = "";
        }

        private void FormRegistrar_Load(object sender, EventArgs e)
        {
            comboBoxCourse.Items.Add("BS Computer Science");
            comboBoxCourse.Items.Add("BS Computer Engineering");            
            comboBoxCourse.Items.Add("BS Information Technology");
            comboBoxCourse.Items.Add("AB Communications");
            comboBoxCourse.Items.Add("BS Hotel and Restaurant Management");

            comboBoxStudentGender.Items.Add("Male");
            comboBoxStudentGender.Items.Add("Female");

            comboBoxStudentCivilStatus.Items.Add("Single");
            comboBoxStudentCivilStatus.Items.Add("Married");
            comboBoxStudentCivilStatus.Items.Add("Divorced");
            comboBoxStudentCivilStatus.Items.Add("Widowed");
        }  
    }
}
