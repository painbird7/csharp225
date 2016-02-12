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
        const int austinFee = 150, chicagoFee = 225, dallasFee = 174, orlandoFee = 300, phoenixFee = 175, raleighFee = 150;

        private void Form1_Load(object sender, EventArgs e)
        {
            Dictionary<string, int> workshopDaysDict = new Dictionary<string, int>();
            workshopDaysDict.Add("Handling Stress", 3);
            workshopDaysDict.Add("Time Management", 3);
            workshopDaysDict.Add("Supervision Skills", 3);
            workshopDaysDict.Add("Negotiation", 5);
            workshopDaysDict.Add("How to Interview", 1);

            Dictionary<string, int> workshopCostDict = new Dictionary<string, int>();
            workshopCostDict.Add("Handling Stress", 1000);
            workshopCostDict.Add("Time Management", 800);
            workshopCostDict.Add("Supervision Skills", 1500);
            workshopCostDict.Add("Negotiation", 1300);
            workshopCostDict.Add("How to Interview", 500);

            Dictionary<string, int> lodgingDict = new Dictionary<string, int>();
            lodgingDict.Add("Austin", 150);
            lodgingDict.Add("Chicago", 225);
            lodgingDict.Add("Dallas", 174);
            lodgingDict.Add("Orlando", 300);
            lodgingDict.Add("Phoenix", 175);
            lodgingDict.Add("Raleigh", 150);
        }
    }
    
}
