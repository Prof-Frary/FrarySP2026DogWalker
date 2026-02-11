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

        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDogOwner.Clear();
            txtNumWalksPerWeek.Clear();
            lstOut.Items.Clear();
            txtDogOwner.Focus();
        }

        private void txtDogOwner_Enter(object sender, EventArgs e)
        {
            txtDogOwner.BackColor = Color.Beige;
        }

        private void txtDogOwner_Leave(object sender, EventArgs e)
        {
            txtDogOwner.BackColor = SystemColors.Window;
        }




        // End of form1
    }
} // end of namespace
