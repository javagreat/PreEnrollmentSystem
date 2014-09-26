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
    public partial class FormFaculty : Form
    {
        public FormFaculty()
        {
            InitializeComponent();
        }

        private void buttonScheduleList_Click(object sender, EventArgs e)
        {
            panelScheduleList.BringToFront();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            panelHome.BringToFront();
        }

        private void buttonViewClassList_Click(object sender, EventArgs e)
        {
            panelClassListView.BringToFront();
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            panelSettings.BringToFront();
        }
    }
}
