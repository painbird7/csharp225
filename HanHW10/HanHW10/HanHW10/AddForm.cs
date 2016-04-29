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
        public AddForm()
        {
            InitializeComponent();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {

        }

        private void addFormExitButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.ReadData();
            this.Close();
        }

        private void addFormClearButton_Click(object sender, EventArgs e)
        {
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
                    MessageBox.Show("Entry has been saved.");


                    // Clear text boxes.
                    cityTextBox.Clear();
                    populationTextBox.Clear();
                }
                else if (saveResult == DialogResult.No)
                {
                    MessageBox.Show("Entry is not saved.");
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
