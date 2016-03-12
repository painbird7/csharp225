using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*  Title: HanHW5 - PresentValue
    Requirement: Write a method named PresentValue that performs this calculation. The method should accept the future value, annual interest rate, and number of years as arguments.  It should return the present value, which is the amount that you need to deposit today.  Demonstrate the method in an application that lets the user experiment with different values for the formula's terms.
    Date: 03/04/2016   
*/

namespace HanHW5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private double PresentValue(double futureValue, double annualInterestRate, double years)
        {
            double denominator = Math.Pow((1 + annualInterestRate), years);
            return futureValue / denominator;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Declar variables to hold three values. 
            double futureValue, annualInterestRate, years, resultNumber;

            // Check all three textboxes and proceed to next if condition if all are filled.
            if ((futureValueTextBox.Text != "") && (annualInterestRateTextBox.Text != "") && (yearsTextBox.Text != ""))
            {
                // Parse user input and pass them to PresentValue method.
                if (double.TryParse(futureValueTextBox.Text, out futureValue) && double.TryParse(annualInterestRateTextBox.Text, out annualInterestRate) && double.TryParse(yearsTextBox.Text, out years))
                {
                    // Get the result and assign it to resultNumber and display it to the present value textbox control.
                    resultNumber = PresentValue(futureValue, annualInterestRate, years);

                    if (resultNumber >= 0.01)
                    {
                        presentValueTextBox.Text = resultNumber.ToString("C");
                    }
                    else
                    {
                        MessageBox.Show("Present value is lower than $0.01. Please adjust your input numbers.");
                    }
                }
                else
                {
                    // Display an error message.
                    MessageBox.Show("Please enter numbers only.", "Input Type Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                // Display an error message.
                MessageBox.Show("Please enter all three values.");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear all four textbox controls.
            futureValueTextBox.Text = string.Empty;
            presentValueTextBox.Text = string.Empty;
            annualInterestRateTextBox.Text = string.Empty;
            yearsTextBox.Text = string.Empty;
        }
    }
}
