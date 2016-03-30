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

/*  Title: HanHW6 - Arrays and Lists
    Requirement: You will find a file named USPopulation.txt attached above.  The file contains the midyear population of the United States, in thousands, during the           years 1950 through 1990.  The first line in the file contains the population for 1950, the second line contains the population for 1951, and so forth.
            Create an application that reads the file's contents into an array or a List.  The application should display the following data:
                •The average annual change in population during the time period
                •The year with the greatest increase in population during the time period
                •The year with the least increase in population during the time period
    Date: 03/28/2016   
*/

namespace HanHW6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Display(List<int> numberList)
        {
            foreach (int number in numberList)
            {
                // Add each value in the list to the list box control.
                listBox.Items.Add(number);
            }
        }

        private void ReadNumber(List<int> numberList)
        {
            try
            {
                // Declare SteamReader object
                StreamReader inputFile;
                // Get root directory of current project.
                string inputFilePath = Environment.CurrentDirectory;
                // Combine two paths into fileName.
                string fileName = Path.Combine(inputFilePath, "USPopulation.txt");
                // Open text file with StreamReader object
                inputFile = File.OpenText(fileName);
                filePathLabel.Text = "File Path:";
                filePathTextBox.Text = fileName.ToString();
                while (!inputFile.EndOfStream)
                {
                    // Add each value to numberList list.
                    numberList.Add(int.Parse(inputFile.ReadLine()));
                }
                // Close StreamReader.
                inputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private double Average(List<int> numberList)
        {
            // Create and initialize variables.
            int total = 0;
            int i = 1;
            double average;
            foreach (int number in numberList)
            {
                // If statement to prevent querying index out of size of numberList.
                if (i < 41)
                {
                    // Subtract index 1 value to index 0 value and increase index number each time and add to the total variable.
                    total += (numberList[i] - numberList[i - 1]);
                    i++;
                }
            }
            // Average calculation
            average = (double)total / (numberList.Count - 1);
            return average;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Create variables and an array to hold the numbers.
                List<int> numberList = new List<int>();
                double average;
                int greatest;
                int least;

                // Call methods to calculate values.
                ReadNumber(numberList);
                Display(numberList);
                average = Average(numberList);
                // Take the average and round to two decimal places and output to the Textbox control.
                annualChangeTextBox.Text = Math.Round(average, 2).ToString();

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
            // Clear each control.
            listBox.Items.Clear();
            filePathTextBox.Text = string.Empty;
            greatestTextBox.Text = string.Empty;
            leastTextBox.Text = string.Empty;
            annualChangeTextBox.Text = string.Empty;
            filePathLabel.Text = string.Empty;
        }
    }
}
