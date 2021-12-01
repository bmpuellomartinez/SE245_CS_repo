using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Berta M. Puello-Martienez
//Date: 11/17/2021
//Instructor: Scott Lambert
//WEEk 6 Activity.

namespace Puello_Week5BookClassInWindows   //File's name.
{
    //Here, I create a class name book. The title and all the other variables are private strings. 
    public class Book
    {
        private string title;  //This is for the title.
        private string authorFirst; //This is for First name.
        private string authorLast; //This is for last name
        private string email; //This is for email
        private DateTime datePublished; // The program has a calender so we are using thte DateTime.
        private double price; // This is not a string, It is a float.
        private int pages;
       

        private string feedback = ""; //This private string will be a public string used so it can display the error back to the user.
       
       
        //create a constuctor...
       //Here I create the public string so the private strings and doubles can be used outside of the book class.
       //The gets and sets will return new value and assign new value to the variables.
       // Each variable has thier own unique name. 
        public string Title 
        {
            get
            {   
                return title;

            }
            set
            {
                if (!ValidationLibrary.GotBadWords(value))
                {
                    title = value;
                }
                else
                {
                    feedback += "ERROR: This Title has bad words. Pleas! No bad works.\n"; //This will check for bad words like "POOP", HOMEWORK, ECT.
                }
                if(ValidationLibrary.CheckingForLength(value))  //This will check for the max length.
                { 
                    title = value;
                }
                else
                {
                    feedback += "ERROR: Pleas Enter the title\n";
                }
            }
        }

        //This is the Feedback
        public string Feedback
        {
            get
            {
                return feedback;
            }
            set
            {
                feedback = value;
            }
        }
        public string AuthorFirst
        {
            get
            {
                return authorFirst;
            }
            set
            {
                if (ValidationLibrary.CheckingForLength(value)) //Checking for the max length.
                {
                    authorFirst = value;
                }
                else
                {
                    feedback += "ERROR: Enter thte first Name\n"; 
                }
                
            }
        }
        public string AuthorLast
        {
            get
            {
                return authorLast;
            }
            set
            {
                if (ValidationLibrary.CheckingForLength(value)) //Checking for the maxium length.
                {
                    authorLast = value;
                }
                else
                {
                    feedback += "ERROR: Enter the last Name\n";
                }
                
            }

        }

        public string Email
        {
            get
            {
                return email;
            }
            set //This set will validate the email that will be enter.
            {
                email = value;
            
                if(ValidationLibrary.IsValidEmail(value))
                {
                    email = value;
                }
                else
                {  //This is a massage that woul be dispay on the feedback
                    feedback += "ERROR: Invalid email\n";
                }

            }
        }

        public DateTime DatePublished //This public is set as a DateTime because it is a calender.
        {
            get
            {
                return datePublished;
            }
            set // This set will validate the date that would be enter and it looking for a future date.
            {
                if(!ValidationLibrary.IsAFutureDate(value))
                {
                    datePublished = value;
                }
                else
                {  //This is the message that will display on the console.
                    feedback +="ERROR: Please enter a past date from today's day.\n";
                }

            }

        }
        public double Price
        {
            get
            {
                return price;
            }
            set
            {   //Here we are validating for the price that is enter.
                if(ValidationLibrary.IsMinimunAmount(value, 1))
                {
                    price = value;
                }
                else
                {   ////This is the message that will display on the console.
                    feedback += "ERROR: Price needs to be greater than 0.\n";
                }

            }
        }

        //Here I added the pages.
        public int Pages
        {
            get
            {
                return pages;
            }
            set
            {

                if(ValidationLibrary.IsMinimunAmount(value, 1)) //Checking for the length.
                {
                    pages = value;
                }
                else
                {
                    feedback += "ERROR: Enter the amount of pages.\n"; //This is a feedback for the user.
                }
 
            }

        }
            
        
    }
}

