using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathQuiz
{
    public partial class Form1 : Form
    {
        // Create a Random object called randomizer
        // to generate the operands for the game
        Random randomizer = new Random();

        int addend1, addend2;

        /// <summary>
        /// Start the quiz by filling in all of the problems
        /// and starting the timer
        /// </summary>
        public void StartTheQuiz()
        {
            // Fill in the addition problem.
            // Generate two random numbers to add.
            // Store the values in 'addend1' and 'addend2'.
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);

            // Convert the two randomly generated numbers to strings
            // so they can be displayed on the labels
            lblPlusLeft.Text = addend1.ToString();
            lblPlusRight.Text = addend2.ToString();

            // 'numCtrlSum' is the name of the NumericUpDown control.
            // This step makes sure its value is zero before
            // adding any values to it.
            numCtrlSum.Value = 0;

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            btnStart.Enabled = false;
        }

        public Form1()
        {
            InitializeComponent();
        }
    }
}
