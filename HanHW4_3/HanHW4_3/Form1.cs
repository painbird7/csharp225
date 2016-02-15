using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*  Title: HanHW4_3 - Random Number File Reader
    Requirement: Create another application that uses an OpenFileDialog control to let the user select the file that was created by the 
    Random Number File Writer application you wrote for problem #2 above.  This application should read the numbers from the file, display 
    the numbers in a ListBox control, and then display the following data:
    - The total of the numbers
    - The number of random numbers read from the file
    Date: 02/14/2016   
*/

namespace HanHW4_3
{
    public partial class Form1 : Form
    {
        // Create a list
        List<int> iList = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Detect the path of documents folder and assign it to initial directory path
                String myDocument = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                openFile.InitialDirectory = myDocument;

                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    // Initialize the streamreader
                    StreamReader reader = new StreamReader(openFile.FileName);
                    // Declare variable to store value in the file and iterate each line in the file and add to list
                    string n;
                    while ((n = reader.ReadLine()) != null)
                    {
                        iList.Add(int.Parse(n));
                    }
                    reader.Close();
                    // Iterate through each item in iList and add to listbox control
                    foreach (int i in iList)
                    {
                        displayListBox.Items.Add(i);
                    }
                    // Display sum and total count of numbers in the file
                    countTextBox.Text = iList.Count.ToString();
                    totalTextBox.Text = (iList.Sum()).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            totalTextBox.Text = string.Empty;
            countTextBox.Text = string.Empty;
            displayListBox.Items.Clear();
        }
    }
}
