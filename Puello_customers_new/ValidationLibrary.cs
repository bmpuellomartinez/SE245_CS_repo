using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puello_WindowsAssigment
//This is my validation Libraty and will check that the user enter a valid information.
{
    class ValidationLibrary
    {
        //This fuction will make sure the answer is not equal to null.
        //The length had tot be bigger than 0.
        public static bool CheckingForLength(string temp)
        {
            bool result = false;

            if (temp.Length > 0)
            {
                result = true;
            }
            return result; //This will validate the input.

        }

        public static bool CheckingForLength(string temp, int min)
        {
            bool result = false;
            if (temp != null)
            {
                if (temp.Length >= min)
                {
                    result = true;
                }
            }
            return result;

        }
        public static bool IsLength(string temp, int max)
        {
            bool result = false;
            if (temp != null)
            {
                if (temp.Length == max)
                {
                    result = true;
                }
            }
            return result;
        }
        

        //This function will check for valid emails.
       public static bool IsValidEmail(string temp)
        {
            bool result = true;


            int atLocation = temp.IndexOf("@");
            int NextatLocation = temp.IndexOf("@", atLocation + 1);

            int periodLocation = temp.LastIndexOf(".");

            if(temp.Length < 8)
            {
                result = false;
            }
            else if(atLocation < 1)
            {
                result = false;
            }
            else if (atLocation < 2)
            {
                result = false;
            }
            else if (periodLocation + 2 > (temp.Length))
            {
                result = false;
            }
            return result;
        }
        //This function will aproved future date.It is commented out because it is not being used.
        public static bool IsAFutureDate(DateTime temp)
        {
            bool result = false;
            if (temp >= DateTime.Now)
            {
                result = true;
            }
            return result; //If the answer is valid the program will aproved it.

        }

        public static bool IsMinimunAmount(double temp, double min)
        {
            bool result = false;

            if (temp >= min)
            {
                result = true;
            }
            return result; 
        }
        public static bool IsMinimunAmount(int temp, int min)
        {
            bool result = false;
            if (temp >= min)
            {
                result = true;
            }

            return result;

        }
    }   

}








