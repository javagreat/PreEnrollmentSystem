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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            panelHome.BringToFront();
        }

        private void buttonManageDatabase_Click(object sender, EventArgs e)
        {
        }

        private void formAdmin_Load(object sender, EventArgs e)
        {
            listBox2.Items.Add("Bachelor of Science in Computer Engineering");
            listBox2.Items.Add("Bachelor of Science in Information Technology");
            listBox2.Items.Add("Bachelor of Science in Computer Science");
            listBox2.Items.Add("Bachelor in Hotel and Restaurant Management");
            listBox2.Items.Add("Bachelor in Business Management");
            listBox2.Items.Add("Bachelor in Tourism Management");
            listBox2.Items.Add("Bachelor in Accounting Technology");
            listBox2.Items.Add("Bachelor in Communication Arts");
        }
    }
}
