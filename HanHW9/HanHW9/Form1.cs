using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
        // Create a list
        List<PreferredCustomer> customerList = new List<PreferredCustomer>();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void ReadFile()
        {
            // Variables to hold input.
            string name = "", address = "", phone = "";
            int customerNumber = 0;
            bool mailing = false;
            decimal purchaseAmount = 0;

            try
            {
                // Read the text file.
                StreamReader inputFile;
                string inputFilePath = Environment.CurrentDirectory;
                string fileName = Path.Combine(inputFilePath, "contacts.txt");
                inputFile = File.OpenText(fileName);

                // Delimiter to split string and variable to hold each line of text
                char[] delim = { ',' };
                string line;
                

                while (!inputFile.EndOfStream)
                {
                    PreferredCustomer myCustomer = new PreferredCustomer(name, address, phone, customerNumber, mailing, purchaseAmount);
                    // Read text.
                    line = inputFile.ReadLine();
                    // Split line with ','.
                    string[] tokens = line.Split(delim);

                    myCustomer.Name = tokens[0];
                    myCustomer.Phone = tokens[1];
                    myCustomer.Address = tokens[2];
                    myCustomer.CustomerNumber = int.Parse(tokens[3]);
                    myCustomer.PurchaseAmount = decimal.Parse(tokens[4]);
                    myCustomer.Mailing = bool.Parse(tokens[5]);
                    customerList.Add(myCustomer);
                    


                    
                }
                inputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            customerNumberTextBox.Clear();
            purchaseAmountTextBox.Clear();
            discountLevelTextBox.Clear();
            listView.Items.Clear();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            int enteredCustomerNumber;
            if (int.TryParse(customerNumberTextBox.Text, out enteredCustomerNumber))
            {
                ReadFile();
                int index = customerList.FindIndex(i => i.CustomerNumber == enteredCustomerNumber);
                if (index != -1)
                {
                    // Change listView properties.
                    listView.View = View.Details;
                    listView.FullRowSelect = true;

                    
                    ListViewItem lvi = new ListViewItem(customerList[index].CustomerNumber.ToString());
                    lvi.SubItems.Add(customerList[index].Name);
                    lvi.SubItems.Add(customerList[index].Phone);
                    lvi.SubItems.Add(customerList[index].Address);
                    lvi.SubItems.Add(customerList[index].Mailing.ToString());
                    lvi.SubItems.Add(customerList[index].PurchaseAmount.ToString());
                    listView.Items.Add(lvi);
                    
                }
                else
                {
                    MessageBox.Show("The customer number does not exist.");
                }
            }
            
            
            
        }
    }
}
