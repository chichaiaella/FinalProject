using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinalProject
{
    public partial class StudentLogin : UserControl
    {
        string name;
        string lastname;
        string password;
        string email;
        public StudentLogin()
        {
            InitializeComponent();
        }

        private void StudentLogin_Load(object sender, EventArgs e)
        {
            pnlSignup.BackColor = Color.FromArgb(150, 0, 0, 0);
            this.BackColor = Color.FromArgb(100, 0, 0, 0);
            btnLogin.BackColor = Color.FromArgb(150, 0, 0, 0);


        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtLoginName.Text == "user" && txtLoginPassword.Text == "user")
            {
                Form1 f = (Form1)this.FindForm();
                dashboard d = new dashboard();
                d.btnTeacher.Visible = false;
                d.Show();
                f.Hide();
                this.Hide();
            }
            else
            {
                if (txtLoginName.Text == "" || txtLoginPassword.Text == "")
                {
                    MessageBox.Show("Please fill in all fields");
                    return;
                }
                else if (txtLoginName.Text == name && txtLoginPassword.Text == password)
                {
                    Form1 f = (Form1)this.FindForm();
                    dashboard d = new dashboard();
                    d.btnTeacher.Visible = false;
                    d.Show();
                    f.Hide();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }
            }
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

        private void chkShow_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShow.Checked)
            {
                txtLoginPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtLoginPassword.UseSystemPasswordChar = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Please contact support for password recovery.");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (txtSUname.Text == "" ||
                txtSUlastname.Text == "" ||
                txtSUPassword.Text == "" ||
                txtGmail.Text == "")
            {
                MessageBox.Show("Please fill in all fields");
            }
            else
            {

                // Assuming you want to store the signup information
                name = txtSUname.Text;
                lastname = txtSUlastname.Text;
                password = txtSUPassword.Text;
                email = txtGmail.Text;

                MessageBox.Show("Sign up successful");
            }
        }

        private void btnFacebook_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Facebook login is not implemented yet.");
        }

        private void btnGmail_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gmail login is not implemented yet.");
        }

        private void chkSignUpPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSignUpPassword.Checked)
            {
                txtSUPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtSUPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
