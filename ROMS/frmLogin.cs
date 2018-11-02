using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace ROMS
{
    public partial class frmLogin : Form
    {        
        string pin;
        public frmLogin()
        {
            InitializeComponent();

        }
        
        private void bimbtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
                

        private void chkHide_CheckedChanged(object sender, EventArgs e)
        {
            txtpin.Focus();
            if (chkHide.Checked)
            {
                txtpin.UseSystemPasswordChar = false;
                chkHide.Image = Properties.Resources.eye_24; //Using Images loaded to Resourses
            }
            else
            {
                txtpin.UseSystemPasswordChar = true;
                chkHide.Image = Properties.Resources.eyehide_24;
            }
        }

        private void numpad_Click(object sender, EventArgs e)
        {
            if(txtpin.Enabled==false)
            {
                SystemSounds.Asterisk.Play();
                txtpin.Clear();
            }
            else
            {
                Bunifu.Framework.UI.BunifuTileButton numpad = (Bunifu.Framework.UI.BunifuTileButton)sender; //Cast sender object to Bunifu TileButton
                txtpin.AppendText(numpad.LabelText);
                if (txtpin.TextLength <= 4)
                    pin = txtpin.Text;
                else
                {
                    SystemSounds.Asterisk.Play();
                    txtpin.Text = pin;
                }
                txtpin.Focus();
            }
                                  
        }

        private void btbtnClear_Click(object sender, EventArgs e)
        {
            txtpin.Clear();
        }

        private void User_CheckedChanged(object sender, EventArgs e)
        {
            txtpin.Clear();
            RadioButton r=(RadioButton)sender;
            if (r.Checked == true)
                txtpin.Enabled = true;
            txtpin.Focus();
        }

        private void tmrClock_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lblDate.Text = DateTime.Now.ToLongDateString();
        }
    }
}
