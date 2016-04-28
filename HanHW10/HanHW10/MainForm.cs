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
        string connectionString;
        SqlConnection connection;
        PopulationDBDataSetTableAdapters.CityTableAdapter cityTableAdapter = new PopulationDBDataSetTableAdapters.CityTableAdapter();

        public MainForm()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["HanHW10.Properties.Settings.PopulationDBConnectionString"].ConnectionString;
        }

        private void mainExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ReadData();
        }

        private void ReadData()
        {
            string query = "Select * From City";

            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
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
            FindMax();
            FindSum();
            FindMin();
            FindAverage();
            
        }

        private void mainAddButton_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.ShowDialog();
        }

        private void FindMax()
        {
            string maxCity;
            double max;
            maxCity = (string)this.cityTableAdapter.MaxCityQuery();
            max = (double)this.cityTableAdapter.MaxQuery();
            highestTextBox.Text = maxCity + ", " + max.ToString();
        }

        private void FindMin()
        {
            string minCity;
            double min;
            minCity = (string)this.cityTableAdapter.MinCityQuery();
            min = (double)this.cityTableAdapter.MinQuery();
            lowestTextBox.Text = minCity + ", " + min.ToString();
        }

        private void FindSum()
        {
            double total;
            total = (double)this.cityTableAdapter.SumQuery();
            totalTextBox.Text = total.ToString();
        }

        private void FindAverage()
        {
            double average;
            average = (double)this.cityTableAdapter.AverageQuery();
            averageTextBox.Text = average.ToString();
        }
    }
}
