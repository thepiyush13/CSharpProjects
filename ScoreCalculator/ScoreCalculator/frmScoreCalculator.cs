
//AUTHOR:			Piyush Tripathi
//COURSE:			ISYS 601 601: FUNDAMENTALS OF BUS PROG
//PROGRAM:			frmScoreCalculator
//PURPOSE:			 Calculate score
//INPUT:			Length and Width
//OUTPUT/DISPLAY:	Letter grade
//HONOR CODE:		“On my honor, as an Aggie, I have neither given nor received unauthorized aid on this academic work.”


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreCalculator
{
    public partial class frmScoreCalculator : Form
    {
        private int scoreTotal;
        private int scoreCount;
        public frmScoreCalculator()
        {
            InitializeComponent();
        }

      
        /// <summary>
        /// Exit button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// clear button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAvg.Text = "";
            txtCount.Text = "";
            txtScore.Text = "";
            txtTotal.Text = "";
            scoreCount = 0;
            scoreTotal = 0;
        }

     
        /// <summary>
        /// add button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //get local values
            int score = Convert.ToInt32(txtScore.Text);
            //update global values
            scoreTotal += score;
            scoreCount += 1;
            int avg = scoreTotal / scoreCount;
            //update textboxes
            txtAvg.Text = Convert.ToString(avg);
            txtTotal.Text = Convert.ToString(scoreTotal);
            txtCount.Text = Convert.ToString(scoreCount);
            //cleanup
            txtScore.Focus();
           


        }
    }
}
