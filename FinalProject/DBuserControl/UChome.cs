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
    public partial class UChome: UserControl
    {
        public UChome()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UChome_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(150, 0, 0, 0);
        }
    }
}
