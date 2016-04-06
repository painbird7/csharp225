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
        const int START_UP_QTY = 20;
        Drink[] softDrinks = new Drink[ARRAY_SIZE];
        int totalQty = 0;
        double totalSales = 0;
        
        
        public Form1()
        {
            InitializeComponent();
            StartUp();
            UpdateTextBox();
        }

        private void StartUp()
        {
            for (int index = 0; index < ARRAY_SIZE; index++)
            {
                softDrinks[index].quantityInStock = START_UP_QTY;
                if (index > 2)
                {
                    // Price for Grape Soda and Cream Soda.
                    softDrinks[index].price = 1.5;
                }
                else
                {
                    // Price for Cola, Lemon Lime, and Root Beer.
                    softDrinks[index].price = 1.0;
                }
            }
        }

        private void UpdateTextBox()
        {
            // Cola, array index[0]. Display price and qty in stock.
            colaQtyTextBox.Text = softDrinks[0].quantityInStock.ToString();
            colaPriceTextBox.Text = softDrinks[0].price.ToString("C");

            // Lemon Lime, array index[1]. Display price and qty in stock.
            lemonLimeQtyTextBox.Text = softDrinks[1].quantityInStock.ToString();
            lemonLimePriceTextBox.Text = softDrinks[1].price.ToString("C");

            // Root Beer, array index[2]. Display price and qty in stock.
            rootBeerQtyTextBox.Text = softDrinks[2].quantityInStock.ToString();
            rootBeerPriceTextBox.Text = softDrinks[2].price.ToString("C");

            // Grape Soda, array index[3]. Display price and qty in stock.
            grapeSodaQtyTextBox.Text = softDrinks[3].quantityInStock.ToString();
            grapeSodaPriceTextBox.Text = softDrinks[3].price.ToString("C");

            // Cream Soda, array index[4]. Display price and qty in stock.
            creamSodaQtyTextBox.Text = softDrinks[4].quantityInStock.ToString();
            creamSodaPriceTextBox.Text = softDrinks[4].price.ToString("C");

            totalQuantityTextBox.Text = totalQty.ToString();
            totalSalesTextBox.Text = totalSales.ToString("C");
        }

        private int GetIndex(string sodaName)
        {
            // Initialize variable.
            int index = 0;
            
            // Compare picture box control's name and return index value.
            switch (sodaName)
            {
                case "colaPictureBox":
                    index = 0;
                    break;
                case "lemonLimePictureBox":
                    index = 1;
                    break;
                case "rootBeerPictureBox":
                    index = 2;
                    break;
                case "grapeSodaPictureBox":
                    index = 3;
                    break;
                case "creamSodaPictureBox":
                    index = 4;
                    break;
            }
            return index;
        }

        private void PerformCalculation(int index)
        {
            softDrinks[index].quantityInStock -= 1;
            totalQty += 1;
            totalSales += softDrinks[index].price;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void colaPictureBox_Click(object sender, EventArgs e)
        {
            int index = 0;
            PictureBox sodaType = (PictureBox)sender;
            string sodaName = sodaType.Name;
            GetIndex(sodaName);
            PerformCalculation(index);
            UpdateTextBox();


        }
    }
}
