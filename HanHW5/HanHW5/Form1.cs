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

        private double PresentValue(double futureValue, double annualInterestRate, int years)
        {
            double denominator = Math.Pow((1 + annualInterestRate), years);
            double result = futureValue / denominator;
            return result;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double futureValue, annualInterestRate;
            int years;
            double.TryParse(futureValueTextBox.Text, out futureValue);
            double.TryParse(annualInterestRateTextBox.Text, out annualInterestRate);
            int.TryParse(yearsTextBox.Text, out years);

            
            presentValueTextBox.Text = PresentValue(futureValue, annualInterestRate, years).ToString("C");

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            futureValueTextBox.Text = string.Empty;
            presentValueTextBox.Text = string.Empty;
            annualInterestRateTextBox.Text = string.Empty;
            yearsTextBox.Text = string.Empty;
        }



    }
}
