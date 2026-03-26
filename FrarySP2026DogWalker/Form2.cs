using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrarySP2026DogWalker
{
    public partial class Form2 : Form
    {
        private Form1 ff;
        public Form2(Form1 form1)
        {
            // this is so form1 can be used anywhere in form2.
            ff = form1;
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            StreamWriter sw;
            decimal temp;
            bool isDWValid, isDPValid, isPSValid;
            isDWValid = decimal.TryParse(txtDogWalkerPrice.Text, out temp );
            if (isDWValid)
            {
                ff.DogWalkPrice = temp;
            }
            isDPValid = decimal.TryParse(txtDogParkPrice.Text, out temp);
            if (isDPValid)
            {
                ff.DogParkPrice = temp;
            }
            isPSValid = decimal.TryParse(txtPetSitPrice.Text, out temp);
            if (isPSValid)
            {
                ff.PetSittingPrice = temp;
            }

            if (!isDWValid || !isDPValid || !isPSValid)
            {
                lblError.Text = "Please enter valid prices.";
                lblError.Visible = true;
                ff.setSettings();
            } else
            {
                sw = File.CreateText(ff.ConfigFile);
                sw.WriteLine(ff.DogWalkPrice);
                sw.WriteLine(ff.DogParkPrice);
                sw.WriteLine(ff.PetSittingPrice);

                sw.Close();

                lblError.Visible = false;
                this.Hide();
            }


                
        }
    }
}
