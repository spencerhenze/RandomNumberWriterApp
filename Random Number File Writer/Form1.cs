using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Random_Number_File_Writer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void writeButton_Click(object sender, EventArgs e)
        {
           
            Random randomGen = new Random(); //Makes a new random number generator object from the "Random" class
            int qtyNumbers; // user specifies the number of random numbers
            int countWritten = 0;

            if (int.TryParse(qtyTextBox.Text, out qtyNumbers)) // if the entry is able to be converted to an iteger, assign the int value to "qtyNumbers" and proceed
            {
                try //main code body starts here
                {
                    StreamWriter outputFile; //Declare a StreamWriter variable

                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        //Create a file and get a StreamWriter object
                        outputFile = File.CreateText(saveFileDialog1.FileName); // create a file and get a streamwriter object

                        while (countWritten <= qtyNumbers)
                        {
                            int randomNumber = randomGen.Next(1, 101); // uses the random number generator object to generate random numbers between 1 and 100
                            outputFile.WriteLine(randomNumber);
                            countWritten++;
                        }

                        outputFile.Close();
                        qtyTextBox.Text = "";
                        MessageBox.Show("The numbers were written to the file");
                    }
                    else //if the user clicks cancel
                    {
                        MessageBox.Show("You did not save your work", "Are you sure?", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                } // end general error message catch
            }

            else
            {
                MessageBox.Show("Plese enter an integer value", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } // end invalid data type error message.





















        } // End Write Numbers Button

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
