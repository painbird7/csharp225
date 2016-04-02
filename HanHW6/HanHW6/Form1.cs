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
            // Declare and initialize variables.
            int increase = 0, startYear = 1950, max, maxIndex, maxYear, min, minIndex, minYear;
            
            // Change ListView options.
            listView.View = View.Details;
            listView.FullRowSelect = true;

            // Declare new lists.
            List<int> yearList = new List<int>();
            List<int> increaseList = new List<int>();

            for (int n = 0; n < numberList.Count; n++)
            {
                // Add 1950 to yearList and initialize new ListViewItem for listView.
                yearList.Add(startYear);
                ListViewItem lvi = new ListViewItem(yearList[n].ToString());

                // Increase 1950 by 1 on each iteration.
                startYear++;
                
                // Add numberList to ListViewItem.
                lvi.SubItems.Add(numberList[n].ToString());

                // If statements to prevent index error while calculating increase value.
                if (n == 0)
                {
                    // Add 0 to increaseList and ListViewItem
                    increaseList.Add(increase);
                    lvi.SubItems.Add(increaseList[n].ToString());
                }
                else if (n > 0 && n < 41)
                {
                    // Do the same as above main if statement but different calculation for increase while n is greater than 0 and less than 41.
                    increase = numberList[n] - numberList[n - 1];
                    increaseList.Add(increase);
                    lvi.SubItems.Add(increaseList[n].ToString());
                }
                else if (n == 41)
                {
                    increase = numberList[n - 1] - numberList[n - 2];
                    increaseList.Add(increase);
                    lvi.SubItems.Add(increaseList[n - 1].ToString());
                }
                // Add ListItemView to listView
                listView.Items.Add(lvi);
            }
            // Find max and min values using LINQ methods.
            max = increaseList.Max();
            min = increaseList.Where(f => f > 0).Min();

            // Find index number of max and min values in increaseList and utilize them to find respective years.
            maxIndex = increaseList.IndexOf(max);
            maxYear = yearList[maxIndex];
            minIndex = increaseList.IndexOf(min);
            minYear = yearList[minIndex];

            // Display findings in textbox controls.
            greatestTextBox.Text = maxYear.ToString();
            leastTextBox.Text = minYear.ToString();
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
                // Call ClearAll method.
                ClearAll();

                // Initialize a new list and declare average.
                List<int> numberList = new List<int>();
                double average;
               
                // Call methods.
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

        private void ClearAll()
        {
            // Clear each control.
            listView.Items.Clear();
            filePathTextBox.Text = string.Empty;
            greatestTextBox.Text = string.Empty;
            leastTextBox.Text = string.Empty;
            annualChangeTextBox.Text = string.Empty;
            filePathLabel.Text = string.Empty;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
    }
}
