using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HanHW10
{
    public partial class AddForm : Form
    {
        // Create table adpater and mainform objects.
        PopulationDBDataSetTableAdapters.CityTableAdapter cityTableAdapter = new PopulationDBDataSetTableAdapters.CityTableAdapter();
        MainForm mainForm = new MainForm();

        public AddForm()
        {
            InitializeComponent();
        }
        
        private void addFormExitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void addFormClearButton_Click(object sender, EventArgs e)
        {
            // Clear text boxes.
            cityTextBox.Clear();
            populationTextBox.Clear();
        }

        private void addFormSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Variables to hold user input.
                string cityNew;
                float populationNew;
                cityNew = cityTextBox.Text;
                populationNew = float.Parse(populationTextBox.Text);

                // Confirm whether to save the data
                DialogResult saveResult = MessageBox.Show("Do you want to save the entry?", "Save Confirmation", MessageBoxButtons.YesNo);
                if (saveResult == DialogResult.Yes)
                {
                    int beforeCount = mainForm.CountRecord(); // Get count prior update
                    this.cityTableAdapter.InsertQuery(cityNew, populationNew); // Launch query.
                    int afterCount = mainForm.CountRecord(); // Get count after update
                    if (afterCount > beforeCount) 
                    {
                        MessageBox.Show("New entry has been saved.");
                        cityTextBox.Clear();
                        populationTextBox.Clear();
                    }
                    else if (afterCount == beforeCount)
                    {
                        MessageBox.Show("New entry was not saved.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Display error message.
                MessageBox.Show(ex.Message);
            }
        }
    }
}
