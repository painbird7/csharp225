using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*  Title: HanHW7 - Drink Vending Machine Simulator
    Requirement: Create an application that simulates a soft-drink vending machine.  The application should let the user select one of five soft drinks. When the application starts, the vending machine will have 20 of each type of soft drink.  Each time the user selects a drink, the application should subtract 1 from the quantity of the selected drink.  It should also update and display the total amount of sales.  If the user selects a drink that is sold out, a message should be displayed indicating so. In the application's code, create a structure that has fields for the following data: Drink name, Drink cost, Number of drinks in machine.
      The program should create an array of five structure objects.  Each element of the array should keep data for a specific type of soft drink
    Date: 04/06/2016   
*/

namespace HanHW7
{
    // Declare structure for Drink
    struct Drink
    {
        public int quantityInStock;
        public double price;
        public string drinkName;
    }

    public partial class Form1 : Form
    {
        // Variables and initialze an array of five Drink objects.
        const int ARRAY_SIZE = 5;
        const int START_UP_QTY = 20;
        Drink[] softDrinks = new Drink[ARRAY_SIZE];
        int totalQty = 0;
        double totalSales = 0;
        
        public Form1()
        {
            // Initial form load, update text boxes.
            InitializeComponent();
            StartUp();
            UpdateTextBox();
        }

        private void StartUp()
        {
            // Assign drink names.
            softDrinks[0].drinkName = "Cola";
            softDrinks[1].drinkName = "Lemon Lime";
            softDrinks[2].drinkName = "Root Beer";
            softDrinks[3].drinkName = "Grape Soda";
            softDrinks[4].drinkName = "Cream Soda";

            // Iterate through softDrinks and assign 20 for start quantity and 1 for prices.
            for (int index = 0; index < ARRAY_SIZE; index++)
            {
                softDrinks[index].quantityInStock = START_UP_QTY;
                softDrinks[index].price = 1.0;

                if (index > 2)
                {
                    // Price for Grape Soda and Cream Soda.
                    softDrinks[index].price = 1.5;
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

            // Total values.
            totalQuantityTextBox.Text = totalQty.ToString();
            totalSalesTextBox.Text = totalSales.ToString("C");
        }

        private void PerformCalculation(int index)
        {
            
            // If statement to prevent stock number going below 0.
            if (softDrinks[index].quantityInStock != 0)
            {
                // Subtract 1 from stock
                softDrinks[index].quantityInStock -= 1;
                
                // Add 1 to total quantity
                totalQty += 1;
                
                // Sum total price 
                totalSales += softDrinks[index].price;

                // Change text of label and color if stock value equals 0.
                if (softDrinks[index].quantityInStock == 0)
                {
                    // Variable for listbox.
                    string OOSLabel = "Out of Stock Items:";

                    // Get drink name based on index number.
                    string OOSName = softDrinks[index].drinkName;

                    // Add OOSLabel in the beginning of listbox if it doesn't exist.
                    int result = outOfStockListBox.FindString(OOSLabel, -1);
                    if (result == -1)
                    {
                        outOfStockListBox.Items.Add(OOSLabel);
                    }
                    
                    // Add name of soda that is out of stock to listbox.
                    outOfStockListBox.Items.Add(OOSName);
                    
                    // Create new lists to work with labels and textboxes.
                    List<Label> qtyLabels = new List<Label>() { colaQtyLabel, lemonLimeQtyLabel, rootBeerQtyLabel, grapeSodaQtyLabel, creamSodaQtyLabel };
                    List<TextBox> qtyTextBoxes = new List<TextBox>() { colaQtyTextBox, lemonLimeQtyTextBox, rootBeerQtyTextBox, grapeSodaQtyTextBox, creamSodaQtyTextBox};

                    // Change label and textbox control properties.
                    qtyLabels[index].Text = "Out of Stock";
                    qtyLabels[index].Font = new Font(qtyLabels[index].Font, FontStyle.Bold);
                    qtyLabels[index].ForeColor = System.Drawing.Color.Red;
                    qtyTextBoxes[index].Hide();
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void PictureBoxClick(object sender, EventArgs e)
        {
            int index = 0;
            
            // Check if sender is a picturebox control.
            if (sender is PictureBox)
            {
                // Get picturebox control's name and assign it to sodaName.
                string sodaName = ((PictureBox)sender).Name;
                
                // Switch statement to assign index number to send over to PerformCalculation method.
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
                
                // Call methods.
                PerformCalculation(index);
                UpdateTextBox();
            }
        }

        // Method to change border style to Fixed3D
        private void ChangeBorderFixed3D(object sender, MouseEventArgs e)
        {
            PictureBox soda = (PictureBox)sender;
            soda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        }

        // Method to change border style to None
        private void ChangeBorderNone(object sender, MouseEventArgs e)
        {
            PictureBox soda = (PictureBox)sender;
            soda.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }
    }
}
