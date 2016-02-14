using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*  Title: HanHW4 - Random Number Guessing Game
    Requirement: Create an application that generates a random number in the range of 1 through 100 and asks the user to guess what the number is.  
    If the user's guess is higher than the random number, the program should display "Too high, try again." If the user's guess is lower than the random number, 
    the program should display "Too low, try again." If the user guesses the number, the application should congratulate the user and then generate a 
    new random number so the game can start over.  The game should keep count of the number of guesses that the user makes.  
    When the user correctly guesses the random number, the program should display the number of guesses along with the congratulations.
    Date: 02/13/2016  
*/

namespace HanHW4
{
    public partial class Form1 : Form
    {
        // Declare fields to be used in the class
        Random rand;
        int number;
        int playCount;
        
        public Form1()
        {
            InitializeComponent();
            rand = new Random();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Call generateNumber method
            generateNumber();
        }

        private void generateNumber()
        {
            // Generate random number, assign integer 1 to playCount variable
            number = rand.Next(1 , 101);
            randomNumberTextBox.Text = number.ToString();
            playCount = 1;
            playCountTextBox.Text = playCount.ToString();
            resultLabel.Text = string.Empty;
            guessTextBox.Text = string.Empty;
            // Change randomNumberTextBox property to hide
            randomNumberTextBox.Visible = false;
        }

        private void generatePlayCount()
        {
            // Increase the count of playCount variable
            playCount++;
            playCountTextBox.Text = playCount.ToString();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }

        private void startNewButton_Click(object sender, EventArgs e)
        {
            // Call generateNumber method
            generateNumber();
        }

        private void guessTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                // Check enter key press
                if (e.KeyCode == Keys.Enter)
                {
                    // Declare variable for user input number
                    int guessedNumber = int.Parse(guessTextBox.Text);

                    // if guess  number is higher than  randomly generated number, inform the user with message box control regarding the result.
                    if (guessedNumber > number)
                    {
                        resultLabel.Text = guessTextBox.Text + " is too high, please try again.";
                        generatePlayCount();
                    }

                    // if guess  number is lower than  randomly generated number, inform the user with message box control regarding the result.
                    else if (guessedNumber < number)
                    {
                        resultLabel.Text = guessTextBox.Text + " is too low, please try again.";
                        generatePlayCount();
                    }

                    else
                    {
                        // Dialogresult to store user choice
                        randomNumberTextBox.Visible = true;
                        resultLabel.Text = string.Empty;
                        DialogResult dialogResult = MessageBox.Show("Congratulations, " + guessedNumber + " was the lucky number and the play count was " + playCountTextBox.Text + ". Are you ready for a new challenge?", "Well done!", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            // Call generateNumber method
                            generateNumber();
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            // Farewell user and close the form
                            MessageBox.Show("See you next time!");
                            this.Close();
                        }
                    }
                    // Clear input text box
                    guessTextBox.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                // Display error message
                MessageBox.Show(ex.Message);
                guessTextBox.Text = string.Empty;
            }
        }
    }
}
