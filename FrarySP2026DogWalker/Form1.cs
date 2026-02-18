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


            // For string variables just set variable to text property



            //for numerics you must convert a string to a number
            


            // do calculation
            // for me that is price of service (walk) multiplied by number of times per week



            // output to list box and make sure it is formatted




        }



        private void Form1_Load(object sender, EventArgs e)
        {

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
            txtNumWalksPerWeek.Clear();
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

      
    }
} // end of namespace
