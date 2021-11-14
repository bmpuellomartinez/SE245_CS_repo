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
        public static bool GotPoop(string temp)
        {
            bool result = false;

            if (temp.Contains("Poop"))
            {

                result = true; 

            }
            return result; //If the answer is valid the program will aproved it.
        }

        //This function will check for a valid emails. The '&&' symbols meabs 'AND'. The '||' symbols means OR.
       
        public static bool IsValidEmail(string temp)
        {   
            bool result = false;

            if (temp.Contains("@") && ( temp.Contains(".com")  || temp.Contains(".org") || temp.Contains(".net")))
            {
                result = true;
            }
            return result; //If the answer is valid the program will aproved it.
        }

        //This function will chack that date entered is a future future date.
        public static bool IsAFutureDate(DateTime temp)
        {
            bool result = false;
           if(temp >= DateTime.Now)
            {
                result = true;
            }
            return result; //If the answer is valid the program will aproved it.

        }

        // This fuctiion is not set up yet.
        // This function will check for amount of letters length entered. This fuctiion is not set up yet.
        public static bool IsItFilledIn(string temp)
        {
            bool result = false;

            if (temp.Length > 0)
            {
                result = true;

            }
            return result; //If the answer is valid the program will aproved it.

        }
        // This fuctiion is not set up yet.
        public static bool CheckingForLength(string temp)
        {
            bool result = false;

            if(temp.Length > 10)
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






    }

}
