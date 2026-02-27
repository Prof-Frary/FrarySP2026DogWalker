using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrarySP2026DogWalker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //ICA 3
            // Declare Variables
            // setting this value to a literal FOR NOW
            decimal servicePrice = 20;
            // going to come from the user
            int timesPerWeek;
            string dogOwner;
            decimal totalPrice;
            //ica 4
            //timesGood is an indication as to whether
            //timesPerWeek was entered as a number 
            bool timesGood, ownerGood;

            // For string variables just set variable to text property
            dogOwner = txtDogOwner.Text;
            if (dogOwner == "")
            {
                ownerGood = false;
            }
            else
            {
                ownerGood = true;
            }
            // alternate way to do above if 
            // ownerGood = dogOwner != "";

            //for numerics you must convert a string to a number
            //  timesPerWeek = int.Parse(txtServicesPerWeek.Text);
            timesGood = int.TryParse(txtServicesPerWeek.Text, out timesPerWeek);
            // do calculation
            // for me that is price of service (walk) multiplied by number of times per week
            if (timesGood && ownerGood)
            { 
                // if user entered a valid numeric do all regular processing
                totalPrice = servicePrice * timesPerWeek;

                // output all variables to list box and make sure it is formatted
                lstOut.Items.Add("The Dog Owner's Name is: " + dogOwner);
                lstOut.Items.Add("The Service Price is: " + servicePrice.ToString("C"));
                lstOut.Items.Add("The Number of Times Per Week is: " + timesPerWeek.ToString("N0"));
                lstOut.Items.Add("The Total Price for the week is: " + totalPrice.ToString("C"));
                // this gives the clear button the focus
                btnClear.Focus();
            } else //error Processing
            {
                if (!ownerGood)
                {
                    lstOut.Items.Add(" Please enter a value for Dog Owner");
                }

                if (!timesGood)
                {
                    lstOut.Items.Add("The number of times per week was not entered as a whole number");
                }
                
                    
            }
            
        }


        private void btnQuit_Click(object sender, EventArgs e)
        {
            //ICA 4
            DialogResult buttonSelected;
            buttonSelected = MessageBox.Show("Do you really want to quit?",
                                              "Exiting...",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question);
            if (buttonSelected == DialogResult.Yes)
            {
                //ICA 2
                this.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //ICA 2
            txtDogOwner.Clear();
            txtServicesPerWeek.Clear();
            lstOut.Items.Clear();
            txtDogOwner.Focus();
        }

        //ICA 2
        private void txtDogOwner_Enter(object sender, EventArgs e)
        {
            txtDogOwner.BackColor = Color.Beige;
        }

        private void txtDogOwner_Leave(object sender, EventArgs e)
        {
            txtDogOwner.BackColor = SystemColors.Window;
        }

        private void txtServicesPerWeek_Leave(object sender, EventArgs e)
        {
            txtServicesPerWeek.BackColor = SystemColors.Window;
        }

        private void txtServicesPerWeek_Enter(object sender, EventArgs e)
        {
            txtServicesPerWeek.BackColor = Color.Beige;
        }
    }
} // end of namespace
