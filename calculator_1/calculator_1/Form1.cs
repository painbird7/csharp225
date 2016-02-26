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
        double loyalty;
        double initialCommission;
        double salesLoyalty;
        double cap;
        double salesCap;
        double salesPrice;
        double lastCommission;

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
                    if ((capCheckBox.Checked) && (loyaltyCheckBox.Checked))
                    {
                        capAndloyaltyCheckedCase();
                    }
                    else if ((capCheckBox.Checked) && (!loyaltyCheckBox.Checked))
                    {
                        capCheckedNoLoyaltyCase();
                    }
                    else if ((!capCheckBox.Checked) && (loyaltyCheckBox.Checked))
                    {
                        loyaltyCheckedNoCapCase();
                    }
                    else if ((!capCheckBox.Checked) && (!loyaltyCheckBox.Checked))
                    {
                        noChecksCase();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                salesPriceTextBox.Text = string.Empty;
                kwTcFeeTextBox.Text = string.Empty;
                loyaltyLabel.Text = string.Empty;
                loyaltyTextBox.Text = string.Empty;
                capLabel.Text = string.Empty;
                capTextBox.Text = string.Empty;
                commissionLabel.Text = string.Empty;
                commissionTextBox.Text = string.Empty;
                lastCommissionTextBox.Text = string.Empty;
                lastCommissionLabel.Text = string.Empty;
                displayLabel.Text = string.Empty;
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
            lastCommissionTextBox.Text = string.Empty;
            lastCommissionLabel.Text = string.Empty;
            displayLabel.Text = string.Empty;
        }


        private void capCheckedNoLoyaltyCase()
        {
            salesPrice = double.Parse(salesPriceTextBox.Text);
            salesKWTCFee = 25;
            kwTcFeeTextBox.Text = salesKWTCFee.ToString("C");
            initialCommission = salesPrice * 0.03;
            commissionTextBox.Text = initialCommission.ToString("C");
            commissionLabel.Text = salesPrice + " x 3% =";
            lastCommission = initialCommission - salesKWTCFee - loyalty;
            lastCommissionTextBox.Text = lastCommission.ToString("C");
            loyalty = initialCommission * 0.06;
            lastCommissionLabel.Text = initialCommission.ToString("#.##") + " - " + salesKWTCFee + " - " + loyalty.ToString("#.##") + " =";
            loyaltyTextBox.Text = loyalty.ToString("C");
            loyaltyLabel.Text = initialCommission + " x " + "6% =";
            displayLabel.Text = "Commission - KW TC Fee - Loyalty";
        }

        private void loyaltyCheckedNoCapCase()
        {
            salesPrice = double.Parse(salesPriceTextBox.Text);
            initialCommission = salesPrice * 0.03;
            commissionTextBox.Text = initialCommission.ToString("C");
            commissionLabel.Text = salesPrice + " x 3% =";
            capLabel.Text = initialCommission + " x 10% =";
            cap = initialCommission * 0.1;
            capTextBox.Text = cap.ToString("C");
            lastCommission = initialCommission - cap;
            lastCommissionLabel.Text = initialCommission + " - " + cap + " =";
            lastCommissionTextBox.Text = lastCommission.ToString("C");
            displayLabel.Text = "Commission - Cap";
        }

        private void capAndloyaltyCheckedCase()
        {
            salesPrice = double.Parse(salesPriceTextBox.Text);
            salesKWTCFee = 25;
            kwTcFeeTextBox.Text = salesKWTCFee.ToString("C");
            initialCommission = salesPrice * 0.03;
            commissionTextBox.Text = initialCommission.ToString("C");
            commissionLabel.Text = salesPrice + " x 3% =";
            lastCommissionLabel.Text = initialCommission + " - " + salesKWTCFee + " =";
            lastCommission = initialCommission - salesKWTCFee;
            lastCommissionTextBox.Text = lastCommission.ToString("C");
            displayLabel.Text = "Commission - KW TC Fee";
        }

        private void noChecksCase()
        {
            salesPrice = double.Parse(salesPriceTextBox.Text);
            initialCommission = salesPrice * 0.03;
            commissionTextBox.Text = initialCommission.ToString("C");
            commissionLabel.Text = salesPrice + " x 3% =";
            capLabel.Text = initialCommission + " x 10% =";
            cap = initialCommission * 0.1;
            capTextBox.Text = cap.ToString("C");
            loyalty = initialCommission * 0.06;
            loyaltyLabel.Text = initialCommission + " x 6% =";
            loyaltyTextBox.Text = loyalty.ToString("C");
            lastCommission = initialCommission - loyalty - cap;
            lastCommissionLabel.Text = initialCommission + " - " + loyalty + " - " + cap + " =";
            lastCommissionTextBox.Text = lastCommission.ToString("C");
            displayLabel.Text = "Commission - Loyalty - Cap";
        }

        private void salesPriceTextBox__KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                // Check enter key press
                if (e.KeyCode == Keys.Enter)
                {
                    if ((capCheckBox_.Checked) && (loyaltyCheckBox_.Checked))
                    {
                        capAndloyaltyCheckedCase();
                    }
                    else if ((capCheckBox_.Checked) && (!loyaltyCheckBox_.Checked))
                    {
                        capCheckedNoLoyaltyCase();
                    }
                    else if ((!capCheckBox_.Checked) && (loyaltyCheckBox_.Checked))
                    {
                        loyaltyCheckedNoCapCase();
                    }
                    else if ((!capCheckBox_.Checked) && (!loyaltyCheckBox_.Checked))
                    {
                        noChecksCase();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                salesPriceTextBox.Text = string.Empty;
                kwTcFeeTextBox.Text = string.Empty;
                loyaltyLabel.Text = string.Empty;
                loyaltyTextBox.Text = string.Empty;
                capLabel.Text = string.Empty;
                capTextBox.Text = string.Empty;
                commissionLabel.Text = string.Empty;
                commissionTextBox.Text = string.Empty;
                lastCommissionTextBox.Text = string.Empty;
                lastCommissionLabel.Text = string.Empty;
                displayLabel.Text = string.Empty;
            }
        }
    }
}
