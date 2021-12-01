using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puello_WindowsAssigment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pSstreet_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblDate.Text = BasicTool.GetToday();
        }

        private void pmnamevar_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblFeedback_Click(object sender, EventArgs e)
        {

        }

        private void feedbackbutton_Click(object sender, EventArgs e)
        {
            //creating a person class
            PersonV2 person = new PersonV2();

            //Creating an double and an int to validate zip, state, phone entry info.
            double dblTemp = 0.0;
            int personTotal;


            //Connecting the public name to each text box that belong to. 
            person.FirstN = txtFname.Text;
            person.MiddleN = txtMname.Text;
            person.LastN = txtLname.Text;
            person.FirstS = txtFstreet.Text;
            person.SecondS = txtSstreet.Text;
            person.City = txtCity.Text;
            person.Email = txtEmail.Text;
            person.URLEmail = txtUrlEmail.Text;

            //This function will check for the State valid entry.
            if (!int.TryParse(txtState.Text, out personTotal) && txtState.Text.Length > 0 )
            {
                person.State = txtState.Text;
            }
            else
            {
                person.feedback += "ERROR: Enter a valid State\n";
            }

            //This function will check for the Zip valid entry.
            if (int.TryParse(txtZip.Text, out personTotal) && txtZip.Text.Length > 0)
            {
                person.Zip = txtZip.Text;
            }
            else
            {
                person.feedback += "ERROR: Enter the 5 digit numbers zip code.\n";
            }

            //This will make sure that the user enter only numbers.
            if (int.TryParse(txtPhone.Text, out personTotal) && txtPhone.Text.Length > 0)
            {
                person.Phone = txtPhone.Text;
            }
            else
            {
                person.feedback += "ERROR: Enter numeric valid phone number.\n";
            }

            //This function will check for only numbers entry.
            if (int.TryParse(txtCellphone.Text, out personTotal) && txtCellphone.Text.Length > 0)
            {
                person.Cellphone = txtCellphone.Text;
            }
            else
            {
                person.feedback += "\nERROR: Enter valid cell phone number.\n";
            }

            //This function will pass douwn value to and also info to the user.
            if (person.feedback.Contains("ERROR"))
            {
                lblFeedback.Text = person.feedback;
            }
            else
            {
                //This will display all the data back to the user.
                lblFeedback.Text = "\nName: " + person.FirstN + "\nMiddle Name: " + person.MiddleN + "\nLast Name: " + person.LastN + "\nStreet Name:" + person.FirstS + "\nSecond street: " + person.SecondS + "\nCity: " + person.City + "\nState: " + person.State + "\nZip: " + person.Zip + "\nPhone: " + person.Phone + "\nCellPhone:" + person.Cellphone + "URL Email" + person.URLEmail +"\nEmail: " + person.Email + "\n" + person.AddingRecord();

            }

        }

        private void txtFname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
