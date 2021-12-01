using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puello_Week5BookClassInWindows
{
    public class Person
    {
        //This is for the first name.
        private string fName;
        //This is for middle name.
        private string MName;
        //This is for  last name.
        private string LName;  
        //Address info the user. 
        private string fStreet;
        //create Stree two
        private string Sstreet;
        //Create City  
        private string City;
        //Create State
        private string State;
        //Create ZipCode
        private string Zip;
        //Create Phone
        private string Phone;
        //Create Email
        private string email;
        //From HERE Down:
        //Public each private string into a new variable with 'Get' and 'Set' and returning the value back.             
        public string FirstN //New Variable Name
        {
            get
            {
                return fName;
            }
            set
            {
                fName = value;
            }
        }

        public string MiddleN //New Variable Name
        {
            get
            {
                return MName;
            }
            set
            {
                MName = value;
            }
        }
        public string LastN //New Variable Name
        {
            get
            {
                return LName;
            }
            set
            {
                LName = value;
            }
        }

        public string FirstS //New Variable Name
        {
            get
            {
                return fStreet;
            }
            set
            {
                fStreet = value;
            }
        }
        public string SecondS //New Variable Name
        {
            get
            {
                return Sstreet;
            }
            set
            {
                Sstreet = value;
            }
        }

        public string city //New Variable Name
        {
            get
            {
                return City;

            }
            set
            {
                City = value;
            }
        }
        public string state //New Variable Name
        {
            get
            {
                return State;
            }
            set
            {
                State = value;
            }
        }
        public string zip //New Variable Name
        {
            get
            {
                return Zip;

            }
            set
            {
                Zip = value;
            }
        }

        public string phoneN //New Variable Name
        {
            get
            {
                return Phone;

            }
            set
            {
                Phone = value;
            }
        }
        public string Email //New Variable Name
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
    }
}

