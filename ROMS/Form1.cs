using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ROMS
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }
        
        private void bimbtnexit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
                

        private void chkHide_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkHide.Checked)
            {
                txtpin.UseSystemPasswordChar = false;
            }
            else
            {
                txtpin.UseSystemPasswordChar = true;
            }
        }

        
    }
}
