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
        double salesKWTCFee_;
        double loyalty_;
        double initialCommission_;
        double salesLoyalty_;
        double cap_;
        double salesCap_;
        double salesPrice_;
        double lastCommission_;
        double salesKWTCFee__;
        double loyalty__;
        double initialCommission__;
        double salesLoyalty__;
        double cap__;
        double salesCap__;
        double salesPrice__;
        double lastCommission__;

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
                clearAll();
            }
        }

        private void clearAll()
        {
            salesPriceTextBox.Text = string.Empty;
            salesPriceTextBox_.Text = string.Empty;
            kwTcFeeTextBox.Text = string.Empty;
            kwTcFeeTextBox_.Text = string.Empty;
            kwTcFeeTextBox__.Text = string.Empty;
            loyaltyLabel.Text = string.Empty;
            loyaltyLabel_.Text = string.Empty;
            loyaltyLabel__.Text = string.Empty;
            loyaltyTextBox.Text = string.Empty;
            loyaltyTextBox_.Text = string.Empty;
            loyaltyTextBox__.Text = string.Empty;
            capLabel.Text = string.Empty;
            capLabel_.Text = string.Empty;
            capLabel__.Text = string.Empty;
            capTextBox.Text = string.Empty;
            capTextBox_.Text = string.Empty;
            capTextBox__.Text = string.Empty;
            commissionLabel.Text = string.Empty;
            commissionLabel_.Text = string.Empty;
            commissionLabel__.Text = string.Empty;
            commissionTextBox.Text = string.Empty;
            commissionTextBox_.Text = string.Empty;
            commissionTextBox__.Text = string.Empty;
            lastCommissionTextBox.Text = string.Empty;
            lastCommissionTextBox_.Text = string.Empty;
            lastCommissionTextBox__.Text = string.Empty;
            lastCommissionLabel.Text = string.Empty;
            lastCommissionLabel_.Text = string.Empty;
            lastCommissionLabel__.Text = string.Empty;
            displayLabel.Text = string.Empty;
            displayLabel_.Text = string.Empty;
            displayLabel__.Text = string.Empty;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clearAll();
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

        private void capCheckedNoLoyaltyCase_()
        {
            salesPrice_ = double.Parse(salesPriceTextBox_.Text);
            salesKWTCFee_ = 12.5;
            kwTcFeeTextBox_.Text = salesKWTCFee_.ToString("C");
            initialCommission_ = salesPrice_ * 0.015;
            commissionTextBox_.Text = initialCommission_.ToString("C");
            commissionLabel_.Text = salesPrice_ + " x 1.5% =";
            lastCommission_ = initialCommission_ - salesKWTCFee_ - loyalty_;
            loyalty_ = initialCommission_ * 0.06;
            lastCommission_ = initialCommission_ - salesKWTCFee_ - loyalty_;
            lastCommissionLabel_.Text = initialCommission_.ToString("#.##") + " - " + salesKWTCFee_ + " - " + loyalty_.ToString("#.##") + " =";
            lastCommissionTextBox_.Text = lastCommission_.ToString("C");
            loyaltyTextBox_.Text = loyalty_.ToString("C");
            loyaltyLabel_.Text = initialCommission_ + " x " + "6% =";
            displayLabel_.Text = "Commission - KW TC Fee - Loyalty";
        }

        private void loyaltyCheckedNoCapCase_()
        {
            salesPrice_ = double.Parse(salesPriceTextBox_.Text);
            initialCommission_ = salesPrice_ * 0.03;
            commissionTextBox_.Text = initialCommission_.ToString("C");
            commissionLabel_.Text = salesPrice_ + " x 3% =";
            capLabel_.Text = initialCommission_ + " x 10% =";
            cap_ = initialCommission_ * 0.1;
            capTextBox_.Text = cap_.ToString("C");
            lastCommission_ = initialCommission_ - cap_;
            lastCommissionLabel_.Text = initialCommission_ + " - " + cap_ + " =";
            lastCommissionTextBox_.Text = lastCommission_.ToString("C");
            displayLabel_.Text = "Commission - Cap";
        }

        private void capAndloyaltyCheckedCase_()
        {
            salesPrice_ = double.Parse(salesPriceTextBox_.Text);
            salesKWTCFee_ = 12.5;
            kwTcFeeTextBox_.Text = salesKWTCFee_.ToString("C");
            initialCommission_ = salesPrice_ * 0.015;
            commissionTextBox_.Text = initialCommission_.ToString("C");
            commissionLabel_.Text = salesPrice_ + " x 1.5% =";
            lastCommissionLabel_.Text = initialCommission_ + " - " + salesKWTCFee_ + " =";
            lastCommission_ = initialCommission_ - salesKWTCFee_;
            lastCommissionTextBox_.Text = lastCommission_.ToString("C");
            displayLabel_.Text = "Commission - KW TC Fee";
        }

        private void noChecksCase_()
        {
            salesPrice_ = double.Parse(salesPriceTextBox_.Text);
            initialCommission_ = salesPrice_ * 0.015;
            commissionTextBox_.Text = initialCommission_.ToString("C");
            commissionLabel_.Text = salesPrice_ + " x 1.5% =";
            capLabel_.Text = initialCommission_ + " x 10% =";
            cap_ = initialCommission_ * 0.1;
            capTextBox_.Text = cap_.ToString("C");
            loyalty_ = initialCommission_ * 0.06;
            loyaltyLabel_.Text = initialCommission_ + " x 6% =";
            loyaltyTextBox_.Text = loyalty_.ToString("C");
            lastCommission_ = initialCommission_ - loyalty_ - cap_;
            lastCommissionLabel_.Text = initialCommission_ + " - " + loyalty_ + " - " + cap_ + " =";
            lastCommissionTextBox_.Text = lastCommission_.ToString("C");
            displayLabel_.Text = "Commission - Loyalty - Cap";
        }

        private void capCheckedNoLoyaltyCase__()
        {
            if (capCheckBox_.Checked)
            {
                salesKWTCFee__ = 12.5;
                kwTcFeeTextBox__.Text = salesKWTCFee__.ToString("C");
                salesPrice__ = double.Parse(salesPriceTextBox_.Text);
                initialCommission__ = salesPrice__ * 0.015;
                commissionTextBox__.Text = initialCommission__.ToString("C");
                commissionLabel__.Text = salesPrice__ + " x 1.5% =";
                loyalty__ = initialCommission__ * 0.06;
                lastCommission__ = initialCommission__ - salesKWTCFee__ - loyalty__;
                lastCommissionLabel__.Text = initialCommission__.ToString("#.##") + " - " + salesKWTCFee__ +" - " + loyalty__.ToString("#.##") + " =";
                lastCommissionTextBox__.Text = lastCommission__.ToString("C");
                loyaltyTextBox__.Text = loyalty__.ToString("C");
                loyaltyLabel__.Text = initialCommission__ + " x " + "6% =";
                displayLabel__.Text = "Commission - KW TC Fee - Loyalty";
            }

            else if (!capCheckBox_.Checked)
            {
                salesPrice__ = double.Parse(salesPriceTextBox_.Text);
                initialCommission__ = salesPrice__ * 0.015;
                commissionTextBox__.Text = initialCommission__.ToString("C");
                commissionLabel__.Text = salesPrice__ + " x 1.5% =";
                loyalty__ = initialCommission__ * 0.06;
                lastCommission__ = initialCommission__ - loyalty__;
                lastCommissionLabel__.Text = initialCommission__.ToString("#.##") + " - " + loyalty__.ToString("#.##") + " =";
                lastCommissionTextBox__.Text = lastCommission__.ToString("C");
                loyaltyTextBox__.Text = loyalty__.ToString("C");
                loyaltyLabel__.Text = initialCommission__ + " x " + "6% =";
                displayLabel__.Text = "Commission - Loyalty";
            }
        }

        private void loyaltyCheckedNoCapCase__()
        {
            if (capCheckBox_.Checked)
            {
                salesKWTCFee__ = 12.5;
                kwTcFeeTextBox__.Text = salesKWTCFee__.ToString("C");
                salesPrice__ = double.Parse(salesPriceTextBox_.Text);
                initialCommission__ = salesPrice__ * 0.015;
                commissionTextBox__.Text = initialCommission__.ToString("C");
                commissionLabel__.Text = salesPrice__ + " x 1.5% =";
                capLabel__.Text = initialCommission__ + " x 10% =";
                cap__ = initialCommission__ * 0.1;
                capTextBox__.Text = cap__.ToString("C");
                lastCommission__ = initialCommission__ - salesKWTCFee__ - cap__;
                lastCommissionLabel__.Text = initialCommission__ + " - " + salesKWTCFee__ + " - " + cap__ + " =";
                lastCommissionTextBox__.Text = lastCommission__.ToString("C");
                displayLabel__.Text = "Commission - KW TC Fee - Cap";
            }

            else if (!capCheckBox_.Checked)
            {
                salesPrice__ = double.Parse(salesPriceTextBox_.Text);
                initialCommission__ = salesPrice__ * 0.015;
                commissionTextBox__.Text = initialCommission__.ToString("C");
                commissionLabel__.Text = salesPrice__ + " x 1.5% =";
                capLabel__.Text = initialCommission__ + " x 10% =";
                cap__ = initialCommission__ * 0.1;
                capTextBox__.Text = cap__.ToString("C");
                lastCommission__ = initialCommission__ - cap__;
                lastCommissionLabel__.Text = initialCommission__ + " - " + cap__ + " =";
                lastCommissionTextBox__.Text = lastCommission__.ToString("C");
                displayLabel__.Text = "Commission - Cap";
            }
        }

        private void capAndloyaltyCheckedCase__()
        {
            if (capCheckBox_.Checked)
            {
                salesPrice__ = double.Parse(salesPriceTextBox_.Text);
                salesKWTCFee__ = 12.5;
                kwTcFeeTextBox__.Text = salesKWTCFee__.ToString("C");
                initialCommission__ = salesPrice__ * 0.015;
                commissionTextBox__.Text = initialCommission__.ToString("C");
                commissionLabel__.Text = salesPrice__ + " x 1.5% =";
                lastCommissionLabel__.Text = initialCommission__ + " - " + salesKWTCFee__ + " =";
                lastCommission__ = initialCommission__ - salesKWTCFee__;
                lastCommissionTextBox__.Text = lastCommission__.ToString("C");
                displayLabel__.Text = "Commission - KW TC Fee";
            }

            else if (!capCheckBox_.Checked)
            {
                salesPrice__ = double.Parse(salesPriceTextBox_.Text);
                initialCommission__ = salesPrice__ * 0.015;
                commissionTextBox__.Text = initialCommission__.ToString("C");
                commissionLabel__.Text = salesPrice__ + " x 1.5% =";
                lastCommissionLabel__.Text = initialCommission__ + " =";
                lastCommission__ = initialCommission__;
                lastCommissionTextBox__.Text = lastCommission__.ToString("C");
                displayLabel__.Text = "Commission";
            }
        }

        private void noChecksCase__()
        {
            if (capCheckBox_.Checked)
            {
                salesPrice__ = double.Parse(salesPriceTextBox_.Text);
                initialCommission__ = salesPrice__ * 0.015;
                salesKWTCFee__ = 12.5;
                kwTcFeeTextBox__.Text = salesKWTCFee__.ToString("C");
                commissionTextBox__.Text = initialCommission__.ToString("C");
                commissionLabel__.Text = salesPrice__ + " x 1.5% =";
                capLabel__.Text = initialCommission__ + " x 10% =";
                cap__ = initialCommission__ * 0.1;
                capTextBox__.Text = cap__.ToString("C");
                loyalty__ = initialCommission__ * 0.06;
                loyaltyLabel__.Text = initialCommission__ + " x 6% =";
                loyaltyTextBox__.Text = loyalty__.ToString("C");
                lastCommission__ = initialCommission__ - salesKWTCFee__ - loyalty__ - cap__;
                lastCommissionLabel__.Text = initialCommission__ + " - " + salesKWTCFee__ + " - " + loyalty__ + " - " + cap__ + " =";
                lastCommissionTextBox__.Text = lastCommission__.ToString("C");
                displayLabel__.Text = "Commission - KW TC Fee - Loyalty - Cap";
            }
            
            else if (!capCheckBox_.Checked)
            {
                salesPrice__ = double.Parse(salesPriceTextBox_.Text);
                initialCommission__ = salesPrice__ * 0.015;
                commissionTextBox__.Text = initialCommission__.ToString("C");
                commissionLabel__.Text = salesPrice__ + " x 1.5% =";
                capLabel__.Text = initialCommission__ + " x 10% =";
                cap__ = initialCommission__ * 0.1;
                capTextBox__.Text = cap__.ToString("C");
                loyalty__ = initialCommission__ * 0.06;
                loyaltyLabel__.Text = initialCommission__ + " x 6% =";
                loyaltyTextBox__.Text = loyalty__.ToString("C");
                lastCommission__ = initialCommission__ - loyalty__ - cap__;
                lastCommissionLabel__.Text = initialCommission__ + " - " + loyalty__ + " - " + cap__ + " =";
                lastCommissionTextBox__.Text = lastCommission__.ToString("C");
                displayLabel__.Text = "Commission - Loyalty - Cap";
            }
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
                        capAndloyaltyCheckedCase_();
                    }
                    else if ((capCheckBox_.Checked) && (!loyaltyCheckBox_.Checked))
                    {
                        capCheckedNoLoyaltyCase_();
                    }
                    else if ((!capCheckBox_.Checked) && (loyaltyCheckBox_.Checked))
                    {
                        loyaltyCheckedNoCapCase_();
                    }
                    else if ((!capCheckBox_.Checked) && (!loyaltyCheckBox_.Checked))
                    {
                        noChecksCase_();
                    }
                    if ((capCheckBox__.Checked) && (loyaltyCheckBox__.Checked))
                    {
                        capAndloyaltyCheckedCase__();
                    }
                    else if ((capCheckBox__.Checked) && (!loyaltyCheckBox__.Checked))
                    {
                        capCheckedNoLoyaltyCase__();
                    }
                    else if ((!capCheckBox__.Checked) && (loyaltyCheckBox__.Checked))
                    {
                        loyaltyCheckedNoCapCase__();
                    }
                    else if ((!capCheckBox__.Checked) && (!loyaltyCheckBox__.Checked))
                    {
                        noChecksCase__();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                clearAll();
            }
        }
    }
}
