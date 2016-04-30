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
    public partial class EditForm : Form
    {
        // Declare variables and create objects.
        PopulationDBDataSetTableAdapters.CityTableAdapter cityTableAdapter = new PopulationDBDataSetTableAdapters.CityTableAdapter();
        protected MainForm mainForm;
        string city;
        float population;
        
        public EditForm(MainForm form)
        {
            this.mainForm = form;
            InitializeComponent();
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            city = this.mainForm.city;
            population = this.mainForm.population;
            oldCityTextBox.Text = city;
            string pop = this.mainForm.population.ToString();
            decimal convertedPopulation = Decimal.Parse(pop, System.Globalization.NumberStyles.Float);
            oldPopulationTextBox.Text = convertedPopulation.ToString();
        }

        private void editFormExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editFormSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string newCity = newCityTextBox.Text;
                float newPopulation = float.Parse(newPopulationTextBox.Text);
                cityTableAdapter.UpdateQuery(newCity, newPopulation, city, population);
                MessageBox.Show("Record has been updated.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
