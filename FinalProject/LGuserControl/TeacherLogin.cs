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
    public partial class TeacherLogin: UserControl
    {
        public TeacherLogin()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 f = (Form1)this.FindForm();
            MainLogin mainLogin = new MainLogin();
            mainLogin.Dock = DockStyle.Fill;
            f.pnlLogin.Visible = true;
            f.pnlLogin.Controls.Clear();
            f.pnlLogin.Controls.Add(mainLogin);
            mainLogin.BringToFront();
            mainLogin.Show();
        }

        private void TeacherLogin_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            else if (txtUsername.Text == "admin" && txtPassword.Text == "admin")
            {
                Form1 f = (Form1)this.FindForm();
                dashboard d = new dashboard();
                d.btndashboard.Visible = false;
                d.Show();
                f.Hide();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
            
        }

        private void chkShow_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShow.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void lnkForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Please contact the administrator for password recovery.");
        }
    }
}
