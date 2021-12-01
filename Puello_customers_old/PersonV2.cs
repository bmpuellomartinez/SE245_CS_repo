using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Web;

namespace Puello_WindowsAssigment
{
    class PersonV2: Person
    {
        private string cellphone;
        private string email;

        public string Cellphone
        {
            get
            {
                return cellphone;
            }
            set
            {
                if (ValidationLibrary.CheckingForLength(value, 10))
                {

                    cellphone = value;
                }
                else
                {
                    feedback += "Pleas enter the 10 digit cellPhone.\n";
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
                if (ValidationLibrary.IsValidEmail(value, 8))
                {
                    email = value;
                }
                else
                {
                    feedback += "ERROR:Enter a valid email.\n";
                }
            }
        }

        //Creating a Constructor
        public PersonV2() : base()
        {
            cellphone = "";
            email = "";
        }

    }
}
