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

        // This integer variable keeps track of the
        // remaining time
        int timeLeft;

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
            timeLeft = 30;
            lblTime.Text = "30 seconds";
            timer1.Start(); 
        }

        private bool CheckTheAnswer()
        {
            if (addend1 + addend2 == numCtrlSum.Value) return true;
            else return false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            btnStart.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {
                timer1.Stop();
                MessageBox.Show("You got all the answers right!", "Congratulations!");
                btnStart.Enabled = true;
            }

            if (timeLeft > 0)
            {
                // Display the new timeLeft
                // by updating the TimeLeft label.
                timeLeft -= 1;
                lblTime.Text = $"{timeLeft} seconds";
            }
            else
            {
                // If the user ran out of time, stop the timer, show
                // a MessageBox, and fill in the answers.
                timer1.Stop();
                lblTime.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");
                numCtrlSum.Value = addend1 + addend2;
                btnStart.Enabled = true;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }
    }
}
