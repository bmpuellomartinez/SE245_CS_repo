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
            Person person = new Person() ;

            //This are all the text car names.
            person.FirstN = txtFname.Text;
            person.MiddleN = txtMname.Text;
            person.LastN = txtLname.Text;
            person.FirstS = txtFstreet.Text;
            person.SecondS = txtSstreet.Text;
            person.City = txtCity.Text;
            person.State = txtState.Text;
            person.Zip = txtZip.Text;
            person.PhoneN = txtPnumber.Text;
            person.Email = txtEmail.Text;


            //This function will pass douwn value to and also info to the user.
            if (person.feedback.Contains("ERROR"))
            {
                lblFeedback.Text = person.feedback;
            }
            else
            {
                //This will display all the data back to the user.
                lblFeedback.Text = "\nName:" + person.FirstN + "\nMiddle Name:" + person.MiddleN + "\nLast Name" + person.LastN + "\nStreet Name:" + person.FirstS + "\nSecond street:" + person.SecondS + "\nCity:" + person.City + "\nState:" + person.State + "\nZip:" + person.Zip + "\nPhone:" + person.PhoneN + "\nEmail:" + person.Email;
            }


        }

        private void txtFname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
