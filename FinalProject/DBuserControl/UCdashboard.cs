using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.DBuserControl
{
    public partial class UCdashboard: UserControl
    {
        public UCdashboard()
        {
            InitializeComponent();
        }

        private void UCdashboard_Load(object sender, EventArgs e)
        {
            pnlMainDash.BackColor = Color.FromArgb(150, 0, 0, 0);
            pnlDashBoardHeader.BackColor = Color.FromArgb(100, 0, 0, 0);
            pnlNavSuject.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void btnCopro_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Computer Programming\nNot implemented yet");
        }

        private void btnDSA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Data Structure and Algorithm\nNot implemented yet.");

        }

        private void btnDistru_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Discrete Mathematics\nNot implemented yet.");
        }

        private void btnOOP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Object Oriented Programming\nNot implemented yet.");
        }
    }
}
