using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Project
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Extra obj = new Extra();
            obj.Show();
        }

        private void eToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void personalDetailsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Staff_Personal obj = new Staff_Personal();
            obj.Show();
        }

        private void academicDetailsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            staff_salary obj = new staff_salary();
            obj.Show();
        }

        private void notificationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Notification obj = new Notification();
            obj.Show();
        }

        private void personalDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stu_Personal obj = new Stu_Personal();
            obj.Show();
        }

        private void marksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Marks obj = new Marks();
            obj.Show();
        }
    }
}
