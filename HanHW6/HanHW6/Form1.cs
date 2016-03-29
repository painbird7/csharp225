﻿using System;
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
                listBox.Items.Add(number);
            }
        }

        private void ReadNumber(List<int> numberList)
        {
            try
            {
                StreamReader inputFile;
                string inputFilePath = Environment.CurrentDirectory;
                string fileName = Path.Combine(inputFilePath, "USPopulation.txt");
                inputFile = File.OpenText(fileName);
                filePathTextBox.Text = fileName.ToString();
                while (!inputFile.EndOfStream)
                {
                    numberList.Add(int.Parse(inputFile.ReadLine()));
                }
                inputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private double Average(List<int> numberList)
        {
            int total = 0;
            double average;
            foreach (int number in numberList)
            {
                total += number;
            }
            average = (double)total / numberList.Count;
            return average;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Create variables and an array to hold the numbers.
                List<int> numberList = new List<int>();
                
                ReadNumber(numberList);
                Display(numberList);
                
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
            listBox.Items.Clear();
            filePathTextBox.Text = String.Empty;
        }
    }
}