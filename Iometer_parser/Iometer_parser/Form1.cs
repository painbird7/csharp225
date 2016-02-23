using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;
using System.Diagnostics;

namespace Iometer_parser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            List<string[]> parsedData = new List<string[]>();
            try
            {
                
                
                // Detect the path of documents folder and assign it to initial directory path
                String myDocument = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                openFile.InitialDirectory = myDocument;

                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    

                    
                    Microsoft.VisualBasic.FileIO.TextFieldParser parser = new Microsoft.VisualBasic.FileIO.TextFieldParser(openFile.FileName);
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(",");
                    parser.TrimWhiteSpace = true;
                    parser.ReadLine();
                    parser.ReadLine();
                    parser.ReadLine();
                    parser.ReadLine();
                    parser.ReadLine();
                    parser.ReadLine();
                    parser.ReadLine();
                    parser.ReadLine();
                    parser.ReadLine();
                    parser.ReadLine();
                    parser.ReadLine();
                    parser.ReadLine();
                    parser.ReadLine();



                    while (!parser.EndOfData)
                    {
                        string[] fields = parser.ReadFields();
                        parsedData.Add(fields);
                        Trace.WriteLine(parsedData);
                        /*foreach (string field in fields)
                        {
                            parsedData.Add(field.ToString());
                            Trace.WriteLine(field);
                            
                        }
                        */

                    }
                    
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
    }
}
