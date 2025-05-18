using FinalProject.DBuserControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class dashboard: Form
    {
        public dashboard()
        {
            InitializeComponent();
            btndashboard.Visible = true;
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            pnlHeader.BackColor = Color.FromArgb(200, 0, 0, 0);
            pnlNavbar.BackColor = Color.FromArgb(150, 0, 0, 0);
            lblLogout.BackColor = Color.FromArgb(100, 0, 0, 0);

            pnlMain.Controls.Clear();
            var uc = new UChome() { Dock = DockStyle.Fill };
            pnlMain.Controls.Add(uc);
          




        }

        private void dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();    
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            // dock to dashboard ,declaring uc as new usercontrol local variable
            var uchome = new UChome() { Dock = DockStyle.Fill };
            pnlMain.Controls.Add(uchome);
        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            var ucdash = new UCdashboard() { Dock = DockStyle.Fill };
            pnlMain.Controls.Add(ucdash);
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            var ucteacher = new Main() { Dock = DockStyle.Fill };
            pnlMain.Controls.Add(ucteacher);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            var ucabout = new UCabout() { Dock = DockStyle.Fill };
            pnlMain.Controls.Add(ucabout);
        }
    }
}
