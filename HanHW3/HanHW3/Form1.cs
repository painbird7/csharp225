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
    }
}
