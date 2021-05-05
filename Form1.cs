using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Averages
{
    public partial class Form1 : Form
    {
        //setup variables
        double sum;
        double inputNumber;
        double numberTotal;
        double average;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //collect the number input
                inputNumber = Convert.ToDouble(inputTextBox.Text);

                //if the number isn't 0, add it to the sum, and increase the number total.
                if (inputNumber != 0)
                {
                    sum = sum + inputNumber;
                    numberTotal++;
                    inputTextBox.Text = "";
                    outputLabel.Text = $"{inputNumber} was added to the sum.";
                }
                //if the input number is 0, calculate the average and output it.
                else
                {
                    average = sum / numberTotal;
                    outputLabel.Text = $"The average of these numbers is {average.ToString("#.##")}";
                    inputTextBox.Text = "";
                }
            }
            //if an invalid number is inputted, send an error message
            catch
            {
                outputLabel.Text = "Please input valid numbers only";
            }






        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            //reset all variables and text boxes
            sum = 0;
            inputNumber = 0;
            numberTotal = 0;
            average = 0;
            outputLabel.Text = "";
            inputTextBox.Text = "";
            
        }
    }
}
