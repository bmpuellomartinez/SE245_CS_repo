using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puello_Week5BookClassInWindows
//This is my validation Libraty and will chekc that the user enter a valid information.
//All of the function will used temp and result. 'temp' is just a name and it could be changeable.
//Recerve a string and we can let user know if it is fiiled in.
//Library of validation we can used in furture projects.
{
    class ValidationLibrary
    {   //This function is not set up yet but we are trying to check for bad worlds.
        public static bool GotBadWords(string temp)
        {

            bool result = false;

            string[] strBadWords = { "POOP", "HOMEWORK", "CACA" };
            foreach (string stBW in strBadWords)
            if (temp.ToUpper().Contains(stBW))
            {

                result = true; 

            }
            return result; //If the answer is valid the program will aproved it.
        }

       
        public static bool IsItFilledIn(string temp, int minlen)
        {
            bool result = false;
            if(temp.Length >= minlen)
            {
                result = true;
            }
            return result;
                
        }


       //This will chack for valid emails.
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

        //This function will chack that date entered is a future future date.
        public static bool IsAFutureDate(DateTime temp)
        {
            bool result = false;
           if(temp >= DateTime.Now.AddDays(14))
            {
                result = true;
            }
            return result; //If the answer is valid the program will aproved it.

        }

        //This function will check for the length.
        public static bool CheckingForLength(string temp)
        {
            bool result = false;

            if(temp.Length > 0)
            {
                result = true;
            }
            return result; //If the answer is valid the program will aproved it.

        }
        //This function will check that the user enter the right amount of price. The price has to be grather than '0' zero.
        public static bool IsMinimunAmount(double temp, double min)
        {
            bool result = false;

            if(temp >= min )
            {
                result = true;
            }
            return result; //If the answer is valid the program will aproved it.
        }
        //This function will make sure that the amount of length is valid.
        public static bool IsMinimunAmount( int temp, int min) 
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
