using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator_1
{
    public partial class Form1 : Form
    {
        double salesKWTCFee;
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void salesPriceTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                // Check enter key press
                if (e.KeyCode == Keys.Enter)
                {
                    
                    double salesCommission = 0.03;
                    double salesLoyalty = 0.06;
                    
                    double salesCap = 0.1;

                    double salesPrice = double.Parse(salesPriceTextBox.Text);
                    double initialCommission = salesPrice * salesCommission;
                    double middleCommission = initialCommission - salesKWTCFee;
                    double loyalty = initialCommission * salesLoyalty;
                    double finalCommission = middleCommission - loyalty;
                    double cap = initialCommission * salesCap;
                    double trueCommission = finalCommission - cap;

                    commissionTextBox.Text = initialCommission.ToString("C");
                    commissionLabel.Text = salesPrice + " x " + salesCommission + " =";
                    middleCommisionTextBox.Text = middleCommission.ToString("C");
                    middleCommissionLabel.Text = initialCommission + " - " + salesKWTCFee + " =";
                    finalCommisionTextBox.Text = finalCommission.ToString("C");
                    finalCommissionLabel.Text = initialCommission + " - " + salesKWTCFee + " - " + loyalty.ToString("C") + " =";
                    loyaltyTextBox.Text = loyalty.ToString("C");
                    loyaltyLabel.Text = initialCommission + " x " + salesLoyalty + " =";
                    kwTcFeeTextBox.Text = salesKWTCFee.ToString("C");
                    capTextBox.Text = cap.ToString("C");
                    capLabel.Text = initialCommission + " x " + salesCap + " =";
                    trueCommissionTextBox.Text = trueCommission.ToString("C");
                    trueCommissionLabel.Text = initialCommission + " - " + salesKWTCFee + " - " + loyalty.ToString("C") + " - " + cap.ToString("C") + " =";
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            salesPriceTextBox.Text = string.Empty;
            kwTcFeeTextBox.Text = string.Empty;
            loyaltyLabel.Text = string.Empty;
            loyaltyTextBox.Text = string.Empty;
            capLabel.Text = string.Empty;
            capTextBox.Text = string.Empty;
            commissionLabel.Text = string.Empty;
            commissionTextBox.Text = string.Empty;
            middleCommisionTextBox.Text = string.Empty;
            middleCommissionLabel.Text = string.Empty;
            finalCommisionTextBox.Text = string.Empty;
            finalCommissionLabel.Text = string.Empty;
            trueCommissionLabel.Text = string.Empty;
            trueCommissionTextBox.Text = string.Empty;
            
        }

        private void capCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (capCheckBox.Checked)
            {
                salesKWTCFee = 25;
            }
            else if (!capCheckBox.Checked)
            {
                salesKWTCFee = 0;
            }
        }
    }
}
