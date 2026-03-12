using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrarySP2026DogWalker
{
    // For 3/12/26
    // Forgot to reset default radio button - done
    // Forgot output of radio button  - done
    //ICA 6
    /*
     * Create a variable to hold the logFile name (string) - done
     * Declare a steamwriter variable -done
     * Open the streamwriter to append - done
     * Close the streamwriter - done
     * in between the open & close output each line going to the list box to the file
     *      - copy the code then chage the method call - done
     *      Make the beginning of the tranaction distinctive & add date and time - done
     */

    // ICA 7 
    /*
     * Create variables for values set in switch statement - done
     * add the configuration file to the bin/debug directory - done
     *      - make sure values are in the file - done
     *      - declare a varible to hold the name of the configuration file - done
     * declare a streamreader variable - done
     * Open streamreader to read  - done
     * Close streamreader - done
     * in bettween open & close read the values in from the file 
     *  (in Form1_Load) one line at a time and store in variables created above  - done 
     * Test each radio button and make sure the correct value gets used in each case - done 
     * 
     * SHow how to add comment to text file and have the code ignore them
     * Change the value of the config file variable - this will cause the system to 
     *  not to find the file  - done 
     *  For 3/17/26
     * What do we do?
     * PostTest Loop & openFileDialog
     * Allow for comments
     */
    public partial class Form1 : Form
    {
        private string dogServiceType = "";
        const string DOG_WALK = "Dog Walk";
        const string DOG_PARK = "Dog Park";
        const string PET_SITTING = "Pet Sitting";
        //ica 7
        private decimal dogWalkPrice = 25;
        private decimal dogParkPrice = 30;
        private decimal petSittingPrice = 40;
        //ica 6 - create variable for log file
        string dwLogFile = "DogWalkerTransaction.log";
        string dwCfgFile = "DogWalkerConfig1.txt";

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
                switch (dogServiceType)
                {
                    case DOG_WALK:
                        servicePrice = dogWalkPrice;
                        break;
                    case DOG_PARK:
                        servicePrice = dogParkPrice;
                        break;
                    case PET_SITTING:
                        servicePrice = petSittingPrice;
                        break;
                    default:
                        lstOut.Items.Add("Error in Switch statement - This should not happen");
                        break;
                }
                // if user entered a valid numeric do all regular processing
                totalPrice = servicePrice * timesPerWeek;

                // output all variables to list box and make sure it is formatted
                lstOut.Items.Add("The Dog Owner's Name is: " + dogOwner);
                // ica 5
                lstOut.Items.Add("The service selected is: " + dogServiceType);
                //ica3
                lstOut.Items.Add("The Service Price is: " + servicePrice.ToString("C"));
                lstOut.Items.Add("The Number of Times Per Week is: " + timesPerWeek.ToString("N0"));
                lstOut.Items.Add("The Total Price for the week is: " + totalPrice.ToString("C"));
               /*
                lstOut.Items.Add(DateTime.Now.ToString("D"));
                lstOut.Items.Add(DateTime.Now.ToString("d"));
                lstOut.Items.Add(DateTime.Now.ToString("T"));
                lstOut.Items.Add(DateTime.Now.ToString("t"));
                lstOut.Items.Add(DateTime.Now.ToString("G"));
               */
                //ICA 6 - writing output to a file
                StreamWriter sw;
                  // opens the file to append to the end
                
                sw = File.AppendText(dwLogFile);
                sw.WriteLine("************* Beginning of transaction at " +
                    DateTime.Now.ToString("G") + "*************");
                sw.WriteLine("The Dog Owner's Name is: " + dogOwner);
                sw.WriteLine("The service selected is: " + dogServiceType);
                sw.WriteLine("The Service Price is: " + servicePrice.ToString("C"));
                sw.WriteLine("The Number of Times Per Week is: " + timesPerWeek.ToString("N0"));
                sw.WriteLine("The Total Price for the week is: " + totalPrice.ToString("C"));
                sw.Close();


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
            //ica 5
            rdoWalk.Checked = true;
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

      
        private void rdoWalk_CheckedChanged(object sender, EventArgs e)
        {
          
            if (rdoWalk.Checked)
            {
                dogServiceType = DOG_WALK;

            }
        }

        private void rdoPark_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoPark.Checked)
            {
                dogServiceType = DOG_PARK;
            }

        }

        private void rdoPetSitting_CheckedChanged(object sender, EventArgs e)
        {
            if(rdoPetSitting.Checked)
            {
                dogServiceType = PET_SITTING;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdoWalk.Checked = true;
            StreamReader sr;
            sr = File.OpenText(dwCfgFile);
            dogWalkPrice = decimal.Parse(sr.ReadLine());
            dogParkPrice = decimal.Parse(sr.ReadLine());    
            petSittingPrice = decimal.Parse(sr.ReadLine());
            sr.Close();
        }
    }
} // end of namespace
