using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*  Title: HanHW4_2 - Random Number File Writer
    Requirement: Create an application that writes a series of random numbers to a file.  Each random number should be in the range of 1 through 100.  
    The application should let the user specify how many random numbers the file will hold and should use a SaveFileDialog control to let the user 
    specify the file's name and location.
    Date: 02/14/2016   
*/

namespace HanHW4_2
{
    public partial class Form1 : Form
    {
        // Declare variables and create a list to store random numbers
        Random rand;
        int number;
        int desiredNumber;
        List<int> iList = new List<int>();

        public Form1()
        {
            InitializeComponent();
            rand = new Random();
        }
        
        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Parse user input and store it into desireNumber variable
                desiredNumber = int.Parse(desiredNumberTextBox.Text);
                // Generate a random number till the number user entered is down to 0 and add it to the iList
                for (int n = desiredNumber; n > 0; n--)
                {
                    number = rand.Next(1, 101);
                    iList.Add(number);
                }

                // Detect the path of documents folder and assign it to initial directory path
                String myDocument = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                saveFile.InitialDirectory = myDocument;

                // SaveFileDialog's save button click event
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Initialize streamwriter
                        StreamWriter writer = new StreamWriter(saveFile.OpenFile());
                        // Iterate through and write each item in iList to file
                        foreach (int i in iList)
                        {
                            writer.WriteLine(i);
                        }
                        // Close file
                        writer.Close();
                        MessageBox.Show("File has been saved.");
                        desiredNumberTextBox.Text = string.Empty;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            desiredNumberTextBox.Text = string.Empty;
        }
    }
}
