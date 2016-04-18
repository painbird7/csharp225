using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*  Title: HanHW9 - Inheritance and Polymorphism
    A retail store has a preferred customer plan where customers can earn discounts on all their purchases.  The amount of a customer's discount is determined by the amount of the customer's cumulative purchases in the store as follows:
    •When a preferred customer spends $500, he or she gets a 5 percent discount on all future purchases.
    •When a preferred customer spends $1000, he or she gets a 6 percent discount on all future purchases.
    •When a preferred customer spends $1500, he or she gets a 7 percent discount on all future purchases.
    •When a preferred customer spends $2000 or more, he or she gets a 10 percent discount on all future purchases.
    Design a class named Person with properties for holding a person's name, address, and telephone number.  Next, design a class named Customer, which is derived from the Person class.  The Customer class should have a property for a customer number and a Boolean property indicating whether the customer wishes to be on a mailing list. Finally, design a class named PreferredCustomer, which is derived from the Customer class.  The PreferredCustomer class should have properties for the amount of the customer's purchases and the customer's discount level.  Demonstrate the class in a simple application.
    Date: 04/18/2016   
*/

namespace HanHW9
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
    }
}
