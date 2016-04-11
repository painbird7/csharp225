using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*  Title: HanHW6 - Classes & 
    Requirement: Create an application with a class named PersonEntry.  The PersonEntry class should have properties for a person's name, e-mail address, and phone number.  Also, create a text file that contains the names, e-mail addresses, and phone numbers for at least five people.  When the application starts, it should read the data from the file and create a PersonEntry object for each person's data.  The PersonEntry objects should be added to a List, and each person's name should be displayed in a list box on the application's main form.  When the user selects a name from the list box, a second form should appear displaying that person's name, e-mail address, and phone number.
    Date: 04/11/2016   
*/

namespace HanHW8
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
