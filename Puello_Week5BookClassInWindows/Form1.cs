using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puello_Week5BookClassInWindows
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Alastname_Click(object sender, EventArgs e)
        {

        }

        private void Afirstname_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //There we are putting the butto to work
        private void addbutton_Click(object sender, EventArgs e)
        {
            Ebook temp = new Ebook();
            double dblTemp = 0.0;
            int temppages;

            //temp is just a name it can be changeable.
            //here are all the text vars with their names.
            temp.Title = txtTitle.Text; //For the text var title.
            temp.AuthorFirst = txtAuthorFirst.Text; //For the author's first name.
            temp.AuthorLast = txtAuthorLast.Text;   //For the author's last name.
            temp.DatePublished = calDate.Value;     //The future date of the book
            temp.Email = txtEmail.Text;             //For the author's email.
            temp.DateRentalExperes = dblDateRental.Value;

            if (Int32.TryParse(txtPages.Text, out temppages))
            {
                temp.Pages = temppages;
            }
            else
            {
                temp.Feedback += "ERROR: Enter the amount of pages\n";
            }
            if(Double.TryParse(txtPrice.Text, out dblTemp))
            {

                temp.Price = dblTemp;        
            }
            else
            {
                temp.Feedback += "ERROR: Enter A valid Price\n"; //console display!
            }
            if (Int32.TryParse(txtBookmark.Text, out temppages))
            {
                temp.BookmarkPage = temppages;
            }
            else
            {
                temp.Feedback += "ERROR: Enter the book mark\n";
            }

            //Pasing value
            if (temp.Feedback.Contains("ERROR:"))
            {
                lblFeedback.Text = temp.Feedback;
            }
            else
            {
                //This will be display back to the console After all the info is correctly entered.
                // lblFeedback.Text = "Title: " + temp.Title + "\nWritten By " + temp.AuthorFirst + "\t " + temp.AuthorLast + "\nPublished "+ temp.DatePublished.ToString() + "\nEmail "+ temp.Email + "\nPrice $" + temp.Price.ToString()  + "\nPages: "+ temp.Pages.ToString() + "\nBook Mark: " + temp.BookmarkPage + "\nRental Date: " + temp.DateRentalExperes.ToString();
                lblFeedback.Text = temp.AddingRecord();
            }


            //bool Member = chkMembership.Checked;
            //MessageBox.Show(Member.ToString());
            //if (!temp.Feedback.Contains("ERROR:"))
            //{
            //    lblFeedback.Text = temp.AddingRecord();
            //}
            //else
            //{
            //    lblFeedback.Text = temp.Feedback;
            //}


        }

        private void titlevar_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblFeedback_Click(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dblDateRental_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
