using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

/*  Title: HanHW10 - Databases
    Requirement: The City column stores the name of a city and the Population column stores the population of that city.  The database has 20 rows already entered.
            Create an application that connects to the PopulationDB.mdf database and allows the user to perform the following:
            •Use data-bound controls to add new rows to the database, change existing rows, and delete rows.
            •Sort the list of cities by population, in ascending order.
            •Sort the list of cities by population, in descending order.
            •Sort the list of cities by name.
            •Get the total population of all the cities.
            •Get the average population of all the cities.
            •Get the highest population.
            •Get the lowest population.
    Date: 04/25/2016   
*/

namespace HanHW10
{
    public partial class MainForm : Form
    {
        // Declare variables to store DB connection info and create table adapter object.
        string connectionString;
        SqlConnection connection;
        PopulationDBDataSetTableAdapters.CityTableAdapter cityTableAdapter = new PopulationDBDataSetTableAdapters.CityTableAdapter();
        
        public MainForm()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["HanHW10.Properties.Settings.PopulationDBConnectionString"].ConnectionString;
        }

        // Values to be used in Edit form.
        public string city { get; set; }
        public float population { get; set; }

        private void mainExitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Call ReadData.
            ReadData();
        }

        public void ReadData()
        {
            string query = "Select * From City";
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                // Create DataTable object and fill the adapter.
                DataTable cityTable = new DataTable();
                adapter.Fill(cityTable);
                
                // Change listview properties.
                listView.View = View.Details;
                listView.FullRowSelect = true;

                // Iterate each row and populate data in the listview
                foreach (DataRow row in cityTable.Rows)
                {
                    ListViewItem lvi = new ListViewItem(row[0].ToString());
                    for (int i = 1; i < cityTable.Columns.Count; i++)
                    {
                        lvi.SubItems.Add(row[i].ToString());
                    }
                    listView.Items.Add(lvi);
                }
            }
            // Call methods.
            FindMax();
            FindSum();
            FindMin();
            FindAverage();
        }

        private void mainAddButton_Click(object sender, EventArgs e)
        {
            // Create and event handler to refresh listview when AddForm closes.
            AddForm addForm = new AddForm();
            addForm.FormClosed += new FormClosedEventHandler(addForm_FormClosed);
            addForm.ShowDialog();
        }

        private void addForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ClearItems();
            ReadData();
        }

        private void mainEditButton_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                // Create and event handler to refresh listview when EditForm closes.
                city = listView.SelectedItems[0].Text;
                population = float.Parse(listView.SelectedItems[0].SubItems[1].Text);
                EditForm editForm = new EditForm(this);
                editForm.FormClosed += new FormClosedEventHandler(editForm_FormClosed);
                editForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a record and try again.");
            }
        }

        private void editForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ClearItems();
            ReadData();
        }

        private void FindMax()
        {
            // Get values from queries and display them on text boxes.
            string maxCity;
            double max;
            maxCity = (string)this.cityTableAdapter.MaxCityQuery();
            max = (double)this.cityTableAdapter.MaxQuery();
            highestTextBox.Text = maxCity + ", " + max.ToString();
        }

        private void FindMin()
        {
            // Get values from queries and display them on text boxes.
            string minCity;
            double min;
            minCity = (string)this.cityTableAdapter.MinCityQuery();
            min = (double)this.cityTableAdapter.MinQuery();
            lowestTextBox.Text = minCity + ", " + min.ToString();
        }

        private void FindSum()
        {
            // Get values from queries and display them on text boxes.
            double total;
            total = (double)this.cityTableAdapter.SumQuery();
            totalTextBox.Text = total.ToString();
        }

        private void FindAverage()
        {
            // Get values from queries and display them on text boxes.
            double average;
            average = (double)this.cityTableAdapter.AverageQuery();
            averageTextBox.Text = Math.Round(average, 0).ToString();
        }

        private void mainDeleteButton_Click(object sender, EventArgs e)
        {
            // Check selected item count
            if (listView.SelectedItems.Count > 0)
            {
                // Assign values from selected items in the list view.
                string city = listView.SelectedItems[0].Text;
                float population = float.Parse(listView.SelectedItems[0].SubItems[1].Text);
                
                // Ask user for confirmation.
                DialogResult saveResult = MessageBox.Show("Do you want to delete " + city + "'s" + " record?", "Save Confirmation", MessageBoxButtons.YesNo);
                if (saveResult == DialogResult.Yes)
                {
                    // Compare record counts
                    int beforeCount = CountRecord();
                    cityTableAdapter.DeleteQuery(city, population);
                    int afterCount = CountRecord();
                    if (afterCount < beforeCount)
                    {
                        MessageBox.Show("Record has been deleted.");
                        ClearItems();
                        ReadData();
                    }
                    else if (afterCount == beforeCount)
                    {
                        MessageBox.Show("Record was not deleted.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a record and try again.");
            }
        }

        public int CountRecord()
        {
            int recordCount = 0;
            recordCount = (int)this.cityTableAdapter.CountQuery();
            return recordCount;
        }

        public void ClearItems()
        {
            // Clear listview and text boxes.
            listView.Items.Clear();
            totalTextBox.Clear();
            highestTextBox.Clear();
            averageTextBox.Clear();
            lowestTextBox.Clear();
        }
    }
}
