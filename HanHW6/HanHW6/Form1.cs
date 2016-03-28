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

namespace HanHW6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Create an array to hold the numbers.
            const int SIZE = 40;
            int[] populations = new int[SIZE];

            // Create streamreader object and reads the txt file.
            StreamReader inputFile;
            string inputFilePath = Environment.CurrentDirectory;
            inputFile = File.OpenText(Path.Combine(inputFilePath, "USPopulation.txt"));
            while (!inputFile.EndOfStream)
            {
                populations = inputFile.ReadLine();
            }
        }
    }
}
