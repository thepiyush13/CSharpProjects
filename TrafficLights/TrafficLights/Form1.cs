using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrafficLights
{
    public partial class frmTrafficLights : Form
    {
        public frmTrafficLights()
        {
            InitializeComponent();
        }

        
        private void disableAll() {
            txtRed.BackColor = Color.DarkGray;
            txtGreen.BackColor = Color.DarkGray;
            txtYellow.BackColor = Color.DarkGray;
        }

        private void txtRed_Enter(object sender, EventArgs e)
        {
            disableAll();
            txtRed.BackColor = Color.Red;
        
        }

        private void txtYellow_Enter(object sender, EventArgs e)
        {

            disableAll();
            txtYellow.BackColor = Color.Yellow;
        }

        private void txtGreen_Enter(object sender, EventArgs e)
        {

            disableAll();
            txtGreen.BackColor = Color.Green;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
