using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Timer
{
    public partial class Form1 : Form
    {
        int counter = 0;

        Stopwatch myWatch = new Stopwatch();

        public Form1()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if(exampleTimer.Enabled == false)
            {
                exampleTimer.Enabled = true;
                startButton.Text = "pause";
                //myWatch.Restart();
                myWatch.Start();
            }
            else
            {
                exampleTimer.Enabled = false;
                startButton.Text = "Start";

                myWatch.Stop();
                timerLabel.Text = $"{myWatch.Elapsed}";
                timerLabel.Text = $"{myWatch.ElapsedMilliseconds}";
            }

           
        }

        private void ExampleTimer_Tick(object sender, EventArgs e)
        {
            counter++;
            countLabel.Text = $"{counter}";

            if (counter % 3 == 1)
            {
                colorLabel.BackColor = Color.Black;
            }
            else if (counter % 3 == 2)
            {
                colorLabel.BackColor = Color.Goldenrod;
            }
            else if (counter % 3 == 3)
            {
                colorLabel.BackColor = Color.White;
            }

            
        }
    }
}
