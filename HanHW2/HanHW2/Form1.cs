using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*  Title: HanHW2
    Requirement: Textboxes should take integers only. User needs to be informed if other values are entered.
    Date: 02/03/2016
*/

namespace HanHW2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }

        private void textBoxCheck()
        {
            /* Count the input of enabled textboxes and subsidize the input to 0 
               if the count of input string is zero
            */
            int permitWCCheck = permitWCTextBox.Text.Length;
            if (permitWCCheck == 0)
            {
                permitWCTextBox.Text = "0";
            }
            int permitSCCheck = permitSCTextBox.Text.Length;
            if (permitSCCheck == 0)
            {
                permitSCTextBox.Text = "0";
            }
            int permitECCheck = permitECTextBox.Text.Length;
            if (permitECCheck == 0)
            {
                permitECTextBox.Text = "0";
            }
        }

        private void clearTextBox()
        {
            // Clear text in each textbox control
            permitWCTextBox.Text = string.Empty;
            permitSCTextBox.Text = string.Empty;
            permitECTextBox.Text = string.Empty;
            revenueECTextBox.Text = string.Empty;
            revenueSCTextBox.Text = string.Empty;
            revenueWCTextBox.Text = string.Empty;
            revenueTRTextbox.Text = string.Empty;
            wcTotalTextBox.Text = string.Empty;
            ecTotalTextBox.Text = string.Empty;
            scTotalTextBox.Text = string.Empty;
            trTotalTextBox.Text = string.Empty;
        }
        
        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Call textBoxCheck method
            textBoxCheck();

            try
            {
                // Constant variables for ticket prices
                const decimal wcPrice = 140, ecPrice = 118, scPrice = 118;
                
                // West commuter. Define the variable for input and convert to int for caculation
                // "C0" is used to format string for currency
                decimal wcValue = decimal.Parse(permitWCTextBox.Text);
                decimal wcResult = wcPrice * wcValue;
                wcTotalTextBox.Text = wcResult.ToString("C0");
                revenueWCTextBox.Text = "$" + wcPrice + " x " + permitWCTextBox.Text;

                // East commuter
                decimal ecValue = decimal.Parse(permitECTextBox.Text);
                decimal ecResult = ecPrice * ecValue;
                ecTotalTextBox.Text = ecResult.ToString("C0");
                revenueECTextBox.Text = "$" + ecPrice + " x " + permitECTextBox.Text;

                // South commuter
                decimal scValue = decimal.Parse(permitSCTextBox.Text);
                decimal scResult = scPrice * scValue;
                scTotalTextBox.Text = scResult.ToString("C0");
                revenueSCTextBox.Text = "$" + scPrice + " x " + permitSCTextBox.Text;

                // Total revenue
                decimal totalRevenueValue = wcResult + ecResult + scResult;
                revenueTRTextbox.Text = wcResult.ToString("C0") + " + " + ecResult.ToString("C0") + " + " + scResult.ToString("C0");
                trTotalTextBox.Text = "= " + totalRevenueValue.ToString("C0");
            }
            catch
            {
                // Display message box to inform the user regarding input data type error and clear text boxes
                clearTextBox();
                MessageBox.Show("Invalid data was entered. Input should be numeric values.", "Invalid entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Call ClearTextBox method
            clearTextBox();
        }
    }
}
