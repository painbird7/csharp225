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
    struct Drink
    {
        public int quantityInStock;
        public double price;
    }
    public partial class Form1 : Form
    {
        const int ARRAY_SIZE = 5;
        Drink[] softDrinks = new Drink[ARRAY_SIZE];
        
        
        public Form1()
        {
            InitializeComponent();
            StartUp();
        }

        private void StartUp()
        {
            int startQty = 20;
            softDrinks[0].quantityInStock = startQty;
            colaQtyTextBox.Text = startQty.ToString();
            lemonLimeQtyTextBox.Text = startQty.ToString();
            rootBeerQtyTextBox.Text = startQty.ToString();
            grapeSodaQtyTextBox.Text = startQty.ToString();
            creamSodaQtyTextBox.Text = startQty.ToString();

            for (int index = 0; index < ARRAY_SIZE; index++)
            {
                softDrinks[index].quantityInStock = startQty;
            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void colaPictureBox_Click(object sender, EventArgs e)
        {
            colaPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            
            colaPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }
    }
}
