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
            if(temp.Length == min)
            {
                result = true;
            }
            return result;
        }

        //This function will check for valid emails.
        public static bool IsValidEmail(string temp, int min)
        {
            bool result = false;

            if(temp.Length >= min && temp.Contains("@"))
            {
                result = true;
            }

            return result; //This will validate the input.
        }
    }
}
        //This function will aproved future date. It is commented out because it is not being used.
        //public static bool IsAFutureDate(DateTime temp)
        //{
        //    bool result = false;
        //   if(temp >= DateTime.Now)
        //    {
        //        result = true;
        //    }
        //    return result; //If the answer is valid the program will aproved it.

        //}






    