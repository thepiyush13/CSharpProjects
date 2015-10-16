using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PushMagic
{
    public partial class frmPushMe : Form
    {
        public frmPushMe()
        {
            InitializeComponent();
        }

        private void btnNorth_Click(object sender, EventArgs e)
        {
            hideButtons();
            btnNorth.Visible = false;
        }      

        private void btnEast_Click(object sender, EventArgs e)
        {
            hideButtons();
            btnEast.Visible = false;
        }

        private void btnWest_Click(object sender, EventArgs e)
        {
            hideButtons();
            btnWest.Visible = false;
        }

        private void btnSouth_Click(object sender, EventArgs e)
        {
            hideButtons();
            btnSouth.Visible = false;
        }

        private void hideButtons()
        {
            btnEast.Visible = true;
            btnWest.Visible = true;
            btnNorth.Visible = true;
            btnSouth.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
