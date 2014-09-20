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
    public partial class formLogin : Form
    {
        public formLogin()
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
                       new formStudent().Show();
                       break;
                    case "administrator":
                       new formAdmin().Show(); 
                       break;
                    case "registrar":
                       new formRegistrar().Show();
                       break;
                    case "faculty":
                       new formFaculty().Show();
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
    }
}
