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
            Customer person = new Customer() ;
            double dblTemp = 0.0;
            int personTotal;

          

            //This are all the text car names.
            person.FirstN = txtFname.Text;
            person.MiddleN = txtMname.Text;
            person.LastN = txtLname.Text;
            person.FirstS = txtFstreet.Text;
            person.SecondS = txtSstreet.Text;
            person.City = txtCity.Text;
            person.Zip = txtZip.Text;
            person.State = txtState.Text;
            person.Email = txtEmail.Text;
            person.EmailURL = txtURLEmail.Text;
            person.Discount = chkDiscountM.Checked;
            person.CustomerSince = calCustomerSince.Value;
         
         
            //This finction will make sure the user's state entry is valid.
            if(!int.TryParse(txtState.Text, out personTotal))
            {
                person.State = txtState.Text;
            }
            else
            {
                person.feedback += "\nERROR: Enter a valid State";
            }

            //This function will make sure that the user is entering numbers.
            if (Double.TryParse(txtTotal.Text, out dblTemp))
            {
                person.TotalPursh = dblTemp;
            }
            else //Feed back 
            {
                person.feedback += "\nERROR: The total amount of money\n";  
            }
            if (int.TryParse(txtRewards.Text, out personTotal)) //corverting the output in to an int
            {
                person.Rewards = personTotal;
            }
            else
            {
                person.feedback += "\nERROR: The enter awards.";
            }

            //This will make sure that the user enter numbers in the zip txt.
            if (!int.TryParse(txtZip.Text, out personTotal))
            {
                person.Zip = txtZip.Text;
            }
            else
            {
                person.feedback += "\nERROR: Enter the 5 zip numbers";
            }

            //This will make sure that the user enter only numbers
            if(int.TryParse(txtPhone.Text, out personTotal))
            {
                person.Phone = txtPhone.Text;
            }
            else
            {
                person.feedback += "\nERROR: Enter valid phone number.";
            }


            //This will make sure that the user enter only numbers
            if (int.TryParse(txtCellphone.Text, out personTotal))
            {
                person.Cellphone = txtCellphone.Text;
            }
            else
            {
                person.feedback += "\nERROR: Enter valid cell phone number.";
            }


            //This function will pass douwn value to and also info to the user.
            if (person.feedback.Contains("ERROR"))
            {
                lblFeedback.Text = person.feedback;
            }
            else
            {
                //This will display all the data back to the user.
                lblFeedback.Text = "\nName: " + person.FirstN + "\nMiddle Name: " + person.MiddleN + "\nLast Name: " + person.LastN + "\nStreet Name:" + person.FirstS + "\nSecond street: " + person.SecondS + "\nCity: " + person.City + "\nState: " + person.State + "\nZip: " + person.Zip + "\nPhone: " + person.Phone + "\nCellPhone:" + person.Cellphone + "URL Email" + person.EmailURL + "\nEmail:"  + person.Email + "\nTotal Pursh: " + person.TotalPursh  + "\nRewards: " + person.Rewards + "\nCustumer Since: " + person.CustomerSince.ToString();
            }

        }

        private void txtFname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtZip_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void calCustomerSince_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtState_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pzip_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }
    }
}
