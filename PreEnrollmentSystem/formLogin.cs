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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            String inputUsername = textBoxUsername.Text;
            String inputPassword = textBoxPassword.Text;

            String queryPassword = this.accountsTableAdapter.getPassword(inputUsername);

            if(inputPassword.Equals(queryPassword)) {
                String queryAccountType = (String)this.accountsTableAdapter.getAccountType(inputUsername);

                switch (queryAccountType)
                {
                    case "student":
                       FormStudent fs = new FormStudent();
                       fs.loadData(inputUsername);
                       fs.Show();
                       break;
                    case "administrator":
                       new FormAdmin().Show(); 
                       break;
                    case "registrar":
                       new FormRegistrar().Show();
                       break;
                    case "faculty":
                       new FormFaculty().Show();
                       break;
                }

                this.Hide();
            }
            else {
                MessageBox.Show("Wrong username or password " + inputPassword + " " + queryPassword + "END");
            }
        }

        private void formLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'enrollmentDataSet.Accounts' table. You can move, or remove it, as needed.
            this.accountsTableAdapter.Fill(this.enrollmentDataSet.Accounts);
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
