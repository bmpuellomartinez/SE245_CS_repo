using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Puello_WindowsAssigment
{

    // Berta M. Puello-Martinez
    // Date: 11/3o/2021
    // Course: SE245.03 C#
    // Instructor: Scott Lambert
    // Lab 5 assigments
    public class Person
    {
        //This are private strings to each get and sets.
        private string fName;
        private string mName;
        private string lName;
        private string fStreet;
        private string sStreet;
        private string city;
        private string state;
        private string phone;
        private string email;
        private string zip;


        //This is for the public string to be used as feedback to the console.
        public string feedback;

        public Person()
        {
            fName = "";
            mName = "";
            lName = "";
            fStreet = "";
            sStreet = "";
            city = "";
            state = "";
            phone = "";
            zip = "";
            feedback = "";

        }

        //There are the pubic strings so they could be used in other files. 
        //Each get and set passed  down the new variavle name
        //New variable name for the user first name.
        public string FirstN
        {
            get
            {
                return fName;
            }
            set
            {   //This is a function so the answer is not null and is filled out. 
                if (ValidationLibrary.CheckingForLength(value, 1))
                {
                    fName = value;
                }
                else
                {
                    feedback += "ERROR: Please enter your first name.\n";
                }
                fName = value;

            }
        }

        //New variable name for the user middle name.
        public string MiddleN
        {
            get
            {
                return mName;
            }
            set
            {
                if (ValidationLibrary.CheckingForLength(value))
                {
                    mName = value;
                }
            }

        }
        //New variable name for the user last name.
        public string LastN
        {
            get
            {
                return lName;
            }
            set
            {
                //This is a function so the answer is not null and is filled out.
                if (ValidationLibrary.CheckingForLength(value, 1))
                {
                    lName = value;
                }
                else
                {
                    feedback += "ERROR: Please enter your last name.\n";
                }
            }
        }
        //New variable name for the user's street name.
        public string FirstS
        {
            get
            {
                return fStreet;
            }
            set
            {
                //This is a function so the answer is not null and is filled out.
                if (ValidationLibrary.CheckingForLength(value, 1))
                {
                    fStreet = value;
                }
                else
                {
                    feedback += "ERROR: Please enter  your street's name.\n";
                }
            }
        }

        //New variable name for the user's second street name.
        public string SecondS
        {
            get
            {
                return sStreet;
            }
            set
            {
                //This is a function so the answer is null and is filled out.
                if (ValidationLibrary.CheckingForLength(value))
                {
                    sStreet = value;
                }

            }
        }

        //New variable name for the user's city name. 
        public string City
        {
            get
            {
                return city;

            }
            set
            {
                //This is a function so the answer is not null and is filled out. The length should be 5 characters.
                if (ValidationLibrary.CheckingForLength(value, 1))
                {
                    city = value;
                }
                else
                {
                    feedback += "ERROR: Enter the name of your occurring city.\n";
                }


            }
        }
        //New variable name for the user's state name.
        public string State
        {
            get
            {
                return state;
            }
            set
            {
                //This is a function so the answer is not null and is filled out. The minimum is two letters.
                if (ValidationLibrary.IsLength(value, 2))
                {
                    state = value;
                }
                else
                {
                    feedback += "ERROR: Enter the name of your state.\n";
                }
            }
        }

        //New variable name for the user's zip code.
        public string Zip
        {
            get
            {
                return zip;

            }
            set
            {
                //This is a function so the answer is not null and is filled out with the minimum .
                if (ValidationLibrary.IsLength(value, 5))
                {
                    zip = value;
                }
                else
                {
                    feedback += "ERROR: Enter Your 5 digits zip code.\n";
                }
            }


        }
        
        public string Phone
        {
            get
            {
                return phone;
            }
            set
            {
                if (ValidationLibrary.CheckingForLength(value, 10))
                {
                    phone = value;
                }
                else
                {
                    feedback += "ERROR:Pleas enter the 10 digit Phone.\n";
                }
            }

        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                //This is a function so the answer is not null and is filled out. The character length of 5.
                if (ValidationLibrary.IsValidEmail(value))
                {
                    email = value;
                }
                else
                {
                    feedback += "ERROR:Enter a valid email.\n";
                }
            }

        }
    }
}
 

