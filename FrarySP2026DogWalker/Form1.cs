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

            // For string variables just set variable to text property
            dogOwner = txtDogOwner.Text;

            //for numerics you must convert a string to a number
            timesPerWeek = int.Parse(txtServicesPerWeek.Text);


            // do calculation
            // for me that is price of service (walk) multiplied by number of times per week

            totalPrice = servicePrice * timesPerWeek;

            // output to list box and make sure it is formatted
            lstOut.Items.Add("The total price this week is: " + totalPrice.ToString("C3"));




        }


        private void btnQuit_Click(object sender, EventArgs e)
        {
            //ICA 2
            this.Close();
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
