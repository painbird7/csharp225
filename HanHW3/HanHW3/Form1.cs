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
            // Close the form
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear textbox and listbox controls
            registrationTextBox.Text = string.Empty;
            lodgingTextBox.Text = string.Empty;
            totalCostTextBox.Text = string.Empty;
            workshopListBox.ClearSelected();
            lodgingListBox.ClearSelected();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Dictionary for workshop type
            Dictionary<string, int> workshopDict = new Dictionary<string, int>();
            workshopDict.Add("Handling Stress", 1000);
            workshopDict.Add("Time Management", 800);
            workshopDict.Add("Supervision Skills", 1500);
            workshopDict.Add("Negotiation", 1300);
            workshopDict.Add("How to Interview", 500);

            // Dictionary for number of days of workshop
            Dictionary<string, int> workshopDayDict = new Dictionary<string, int>();
            workshopDayDict.Add("Handling Stress", 3);
            workshopDayDict.Add("Time Management", 3);
            workshopDayDict.Add("Supervision Skills", 3);
            workshopDayDict.Add("Negotiation", 5);
            workshopDayDict.Add("How to Interview", 1);

            // Dictionary for lodge
            Dictionary<string, int> lodgingDict = new Dictionary<string, int>();
            lodgingDict.Add("Austin", 150);
            lodgingDict.Add("Chicago", 225);
            lodgingDict.Add("Dallas", 174);
            lodgingDict.Add("Orlando", 300);
            lodgingDict.Add("Phoenix", 175);
            lodgingDict.Add("Raleigh", 150);

            // Validate iput from both listbox controls
            if ((workshopListBox.SelectedIndex != -1) & (lodgingListBox.SelectedIndex != -1))
            {
                // Declare variables. Some of them are using dictionary key comparison to store corresponding value to variables
                string workshopType = workshopListBox.SelectedItem.ToString();
                string lodgingType = lodgingListBox.SelectedItem.ToString();
                int workshopValue = workshopDict[workshopType];
                int lodgingDay = workshopDayDict[workshopType];
                int lodgingValue = lodgingDict[lodgingType];
                int lodgingTotal = lodgingValue * lodgingDay;

                registrationTextBox.Text = workshopValue.ToString("C0");
                lodgingTextBox.Text = lodgingValue.ToString("C0") + " x " + lodgingDay.ToString() + " days = " + lodgingTotal.ToString("C0");
                totalCostTextBox.Text = (workshopValue + lodgingTotal).ToString("C0");
            }

            else
            {
                // Display message box for missing user inputs
                MessageBox.Show("Please select workshop and lodging location.");
            }
        }
    }
}
