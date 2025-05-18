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
    public partial class UCabout: UserControl
    {
        public UCabout()
        {
            InitializeComponent();
        }

        private void UCabout_Load(object sender, EventArgs e)
        {
            flpAbout.BackColor = Color.FromArgb(150, 0, 0, 0);
        }
    }
}
