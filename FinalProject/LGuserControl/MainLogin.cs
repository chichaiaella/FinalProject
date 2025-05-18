using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class MainLogin: UserControl
    {
        public MainLogin()
        {
            InitializeComponent();
        }

        private void pnlTeacher_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainLogin_Click(object sender, EventArgs e)
        {

        }

        private void MainLogin_Load(object sender, EventArgs e)
        {
            pnlLogin.BackColor = Color.FromArgb(150, 0, 0, 0);
            pnlTeacher.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            Form1 f = (Form1)this.FindForm();
            StudentLogin studentLogin = new StudentLogin();
            studentLogin.Dock = DockStyle.Fill;
            f.pnlLogin.Visible = true;
            f.pnlLogin.Controls.Clear();
            f.pnlLogin.Controls.Add(studentLogin);
            studentLogin.BringToFront();
            studentLogin.Show();
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            Form1 f = (Form1)this.FindForm();
            TeacherLogin teacherLogin = new TeacherLogin();
            teacherLogin.Dock = DockStyle.Fill;
            f.pnlLogin.Visible = true;
            f.pnlLogin.Controls.Clear();
            f.pnlLogin.Controls.Add(teacherLogin);
            teacherLogin.BringToFront();
            teacherLogin.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void lblHeader_Click(object sender, EventArgs e)
        {

        }

        private void pnlLogin_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
