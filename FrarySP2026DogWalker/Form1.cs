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
     * SHow how to add comment to text file and have the code ignore them - done
     * Change the value of the config file variable - this will cause the system to 
     *  not to find the file  - done 
     *  For 3/17/26
     * What do we do?
     * PostTest Loop & openFileDialog - done
     * Allow for comments -done
     */
    /* Classes & overview 3/24
     * ICA 8 - Properties - we need properties to be able to use data across classes/objects
     *  create properties fro each variable in the config file - suggestion - just make the 
     *  first Letter a capital
     * ICA 9 - Second Form creation - finish form for next class (3/26)
     *  - second form should have a label and textbox for each value 
     *      in the text file as well as a return button and textboxes modifiers 
     *      should be internal or public
     * add object creation for second form
     * add menu item on tranaction form to show second form
     * write code to populate the second form text boxes and show second form
     * write return code to save values in textboxes to the properties. 
     * On a failure stay on the second form and redisplay the values
     * On success, save all the values and hide second form so only first form shows
     */
    public partial class Form1 : Form
    {
        private string dogServiceType = "";
        const string DOG_WALK = "Dog Walk";
        const string DOG_PARK = "Dog Park";
        const string PET_SITTING = "Pet Sitting";
        const int LISTBOX = 1;
        const int FILE = 2;
        const int BOTH = 3;
        //ica 7
        private decimal dogWalkPrice = 25;
        private decimal dogParkPrice = 30;
        private decimal petSittingPrice = 40;
        //ica 6 - create variable for log file
        private string dwLogFile = "DogWalkerTransaction.log";
        private string dwCfgFile = "DogWalkerConfig.txt";
        // ICA 9 - this declares the form2 variable
        private Form2 settingForm;
        public Form1()
        {
            InitializeComponent();
            // ICA 9 - this creates the form 2 object
            settingForm = new Form2(this);
        }
        //ICA 8 Properties
        //Add Properties for service Prices
        //properties start with uppercase lettere
        // remember variables start with lowercase
        internal decimal DogWalkPrice
        {
            get { return dogWalkPrice; }
            set { dogWalkPrice = value; }
        }
        internal decimal DogParkPrice
        {
            get { return dogParkPrice; }
            set { dogParkPrice = value; }
        }
        internal decimal PetSittingPrice
        {
            get { return petSittingPrice; }
            set { petSittingPrice = value; }
        }
        internal string ConfigFile
        {
            get { return dwCfgFile; }
            set { dwCfgFile = value; }
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
            string firstName = "";
            string lastName = "";
            char c = 's';
            int i = (int)c; //converts a character to its numeric value
            c = (char)i; // converts an interger to its ascii char
            //ica 4
            //timesGood is an indication as to whether
            //timesPerWeek was entered as a number 
            bool timesGood, ownerGood;

            // For string variables just set variable to text property
            dogOwner = txtDogOwner.Text.Trim();
            // Strings always are surrounded by double quotes ""
            string name = "George Washington";
            //             01234567890123456
            //strings have methods associated with them that allow you
            // to do things like find the length of the string,
            // change case, etc.
            // each letter in the string can be located by its index as shown above

            int len = name.Length;// this will return the length of the string - in this case 17
            int posSpace = dogOwner.IndexOf(" ");// this will return the position of the first space - in this case 6
            if (posSpace != -1)
            {
                firstName = dogOwner.Substring(0, posSpace);
                lastName = dogOwner.Substring(posSpace + 1).Trim();

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
                            servicePrice = DogWalkPrice;
                            break;
                        case DOG_PARK:
                            servicePrice = DogParkPrice;
                            break;
                        case PET_SITTING:
                            servicePrice = PetSittingPrice;
                            break;
                        default:
                            lstOut.Items.Add("Error in Switch statement - This should not happen");
                            break;
                    }
                    // if user entered a valid numeric do all regular processing
                    totalPrice = servicePrice * timesPerWeek;
                    outputMessage("************* Beginning of transaction at " + DateTime.Now.ToString("G") + "*************", FILE);
                    // output all variables to list box and make sure it is formatted
                    outputMessage("The Dog Owner's Name is: " + dogOwner, BOTH);
                    outputMessage("First Name: " + firstName, LISTBOX);
                    outputMessage("Last Name: " + lastName, LISTBOX);

                    outputMessage("The service selected is: " + dogServiceType, BOTH);
                    outputMessage("The Service Price is: " + servicePrice.ToString("C"), BOTH);
                    outputMessage("The Number of Times Per Week is: " + timesPerWeek.ToString("N0"), BOTH);
                    outputMessage("The Total Price for the week is: " + totalPrice.ToString("C"), BOTH);
                  


                    // this gives the clear button the focus
                    btnClear.Focus();
                }
                else //error Processing
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
            else
            {
            }
        }

        private void outputMessage(string message, int Location)
        {
            if (Location == LISTBOX || Location == BOTH)
            {
                lstOut.Items.Add(message);
            }
            if ( Location == FILE || Location == BOTH)
            {
                StreamWriter sw = File.AppendText(dwLogFile);
                sw.WriteLine(message);
                sw.Close();
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
            if (rdoPetSitting.Checked)
            {
                dogServiceType = PET_SITTING;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            const string COMMENT_CHAR = "#";
            rdoWalk.Checked = true;
            StreamReader sr;
            bool fileGood = true;
            do
            {
                try
                {
                    // this line throw an exception of it can't find the file
                    sr = File.OpenText(dwCfgFile);
                    fileGood = true;
                    // the post test loops allow for using a cooment character
                    // as the first character in the config file
                    string temp = "";
                    do
                    {
                        temp = sr.ReadLine();
                    } while (temp.Substring(0, 1) == COMMENT_CHAR);
                    dogWalkPrice = decimal.Parse(temp);

                    do
                    {
                        temp = sr.ReadLine();
                    } while (temp.Substring(0, 1) == COMMENT_CHAR);
                    dogParkPrice = decimal.Parse(temp);

                    do
                    {
                        temp = sr.ReadLine();
                    } while (temp.Substring(0, 1) == COMMENT_CHAR);
                    petSittingPrice = decimal.Parse(temp);
                    sr.Close();
                }
                catch (FileNotFoundException fnf)
                {
                    fileGood = false;
                    /*
                    //fake fix just to figure out what to do next
                    dwCfgFile = "DogWalkerConfig.txt";
                    */

                    // MessageBox allowed here because there is no form yet so user would
                    // have no idea why the openFileDialog is coming up
                    //fnf.Message is the message from the exception - \n is a new line character
                    MessageBox.Show(fnf.Message + "\n\nPlease enter the Configuration File",
                    "Configuration File not Found");
                    // OpenFileDialog Must be added from the toolbox!!!
                    openFileDialog1.Filter = "Text Files|*.txt|All Files|*.*";
                    openFileDialog1.ShowDialog(this);
                    dwCfgFile = openFileDialog1.FileName;
                }
            } while (!fileGood);
        }

        internal void setSettings()
        {
            // text boxes on the second form must be populated before 
            // the form is shown
            settingForm.txtDogWalkerPrice.Text = DogWalkPrice.ToString();
            settingForm.txtDogParkPrice.Text = DogParkPrice.ToString();
            settingForm.txtPetSitPrice.Text = PetSittingPrice.ToString();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setSettings();
            // shows the second form
            settingForm.ShowDialog();
        }

        private void printLogFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //read in all log entries to the ARRAY 

            string[] DogWalkerLogEntries;
            const int MAX_ENTRIES = 2000;
            DogWalkerLogEntries = new string[MAX_ENTRIES];
            StreamReader sr = File.OpenText(dwLogFile);
            int numEntries = 0;
            while (!sr.EndOfStream)
            {
                DogWalkerLogEntries[numEntries] = sr.ReadLine();
                numEntries++;
            }
            sr.Close();
            string rbOutputText = "The service selected is: " + dogServiceType;
            int rbTextLine = 2;
            int endTransLine = 3;
            int transSize = 6;
            // output the array to the list box
            for (int i = rbTextLine; i < numEntries; i+=transSize)
            {
                if (DogWalkerLogEntries[i] == rbOutputText)
                {
                    for (int j = i - rbTextLine; j <= i + endTransLine; j++)
                    {
                        lstOut.Items.Add(DogWalkerLogEntries[j]);
                    }
                   
                   
                }

            }

        }
    }
} // end of namespace
