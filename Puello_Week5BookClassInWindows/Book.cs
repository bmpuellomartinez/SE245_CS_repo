using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Berta M. Puello-Martienez
//Date: 11/12/2021
//Instructor: Scott Lambert
//WEEk 5 Activity.

namespace Puello_Week5BookClassInWindows   //File's name.
{
    //Here, I create a class name book. The title and all the other variables are private strings. 
    public class Book
    {
        private string title; 
        private string authorFirst;
        private string authorLast;
        private string email;
        private DateTime datePublished; // The program has a calender so we are using thte DateTime.
        private double price; // This is not a string, It is a float.

        private string feedback = " "; //This private string will be a public string used so it can display the error back to the user.
       
       
        //create a constuctor...
       //Here I create the public string so the private strings and doubles can be used outside of the book class.
       //The gets and sets will return new value and assing new value to the variables.
       // Each variable has thier own unique name. 
        public string Title 
        {
            get
            {   
                return title;

            }
            set
            {
                title = value;
            }
        }

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
                authorFirst = value;
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
                authorLast = value;
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
                if(ValidationLibrary.IsAFutureDate(value))
                {
                    datePublished = value;
                }
                else
                {  //This is the message that will display on the console.
                    feedback += "ERROR: Please Enter A Future Date.\n";
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
                    feedback += "ERROR: Price needs to be greater than 1.\n";
                }

            }
        }
        
    }
}

