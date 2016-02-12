using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*  Title: HanHW3
    Requirement: Create an application that lets the user select a workshop from one ListBox and a location from another ListBox.  When the user clicks a button, the application should calculate and display the registration cost, the lodging cost, and the total cost. Include a Clear button that clears the costs from the previous selections and resets the focus of the ListBoxes so that none of the options in either ListBox are selected.
    Date: 02/10/2016 
*/

namespace HanHW3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            registrationTextBox.Text = string.Empty;
            lodgingTextBox.Text = string.Empty;
            totalCostTextBox.Text = string.Empty;
            workshopListBox.ClearSelected();
            lodgingListBox.ClearSelected();

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {

            if (workshopListBox.SelectedIndex != -1)
            {
                string workshopType = workshopListBox.SelectedItem.ToString();

                switch (workshopType)
                {
                    case "Handling Stress":
                        registrationTextBox.Text = int.Parse("1000").ToString("C");
                        break;
                    case "Time Management":
                        registrationTextBox.Text = int.Parse("800").ToString("C");
                        break;
                    case "Supervision Skills":
                        registrationTextBox.Text = int.Parse("1500").ToString("C");
                        break;
                    case "Negotiation":
                        registrationTextBox.Text = int.Parse("1300").ToString("C");
                        break;
                    case "How to Interview":
                        registrationTextBox.Text = int.Parse("500").ToString("C");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Please select a workshop.");
            }

            if (lodgingListBox.SelectedIndex != -1)
            {
                string lodgingType = lodgingListBox.SelectedItem.ToString();

                switch (lodgingType)
                {
                    case "Austin":
                        lodgingTextBox.Text = int.Parse("150").ToString("C");
                        break;
                    case "Chicago":
                        lodgingTextBox.Text = int.Parse("225").ToString("C");
                        break;
                    case "Dallas":
                        lodgingTextBox.Text = int.Parse("174").ToString("C");
                        break;
                    case "Orlando":
                        lodgingTextBox.Text = int.Parse("300").ToString("C");
                        break;
                    case "Phoenix":
                        lodgingTextBox.Text = int.Parse("175").ToString("C");
                        break;
                    case "Raleigh":
                        lodgingTextBox.Text = int.Parse("150").ToString("C");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Please select a lodging location.");
            }
        }
    }
}
