using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HanHW7
{
    public partial class Form1 : Form
    {
        const int ARRAY_SIZE = 5;
        Drink[] softDrinks = new Drink[ARRAY_SIZE];
        


        struct Drink
        {
            public int quantityInStock;
            public double price;
        }


        private void colaPictureBox_Click(object sender, EventArgs e)
        {
            softDrinks.qu


        }

        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
