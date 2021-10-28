// Berta M. Puello-Martinez
// Date: 10/10/2021
// Course: SE245.03 C#
// Instructor: Scott Lambert

// Document assigments:
/*This program will allow the users to enter two numbers. Also, the program will add, subtract, multiply and divide the
the numbers. The program will exit after the users is done implementing the numbers. This program could be considere
as basic calculator. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// uisng System.Data; <- we will be using this later in the course!

namespace Puello_Lab1     //Name of the file.
{
    class Program
    {
        static void Main(string[] arg)  //This is a fuction.
      
        {

            String strFname, strOperand, strNum1, strNum2;
            /* Int32 intNum1 = 0, intNum2 = 0, intNum3, intResult = 0;
            Double dblResult;*/

            Double dblNum1 = 0, dblNum2 = 0, dblResult = 0; //This are my integers. 

            Console.WriteLine("Hello There!");            //This is just a hello message that will show on the console.
            Console.Write("Enter your First Name: ");     // <---The user will have to enter his named
            strFname = Console.ReadLine();

            Console.WriteLine("Hello there " + strFname + "! Lets Do Some MATH!"); //This says hi back to the users.

            //Here the program starts to ask the user for the first number.
            Console.WriteLine("Enter the FIRST Number: "); 
            strNum1 = Console.ReadLine();                //This will read back to the console.

            //This will allow the user to select the operational math. 
            Console.Write("Enter the math operation (PLUS, MINUS, MULTIPLY, DIVIDE): ");//This is the operational math cal.
            strOperand = Console.ReadLine().ToUpper();   //This will read the line back to the console.
            
            //This is for the user to enter the second number so it could be added or subtrated and etc, with the first number.
            Console.Write("Enter the SECOND Number: ");
            strNum2 = Console.ReadLine();

            /*
             You can also Uppercase like this
            strOperand = strOperant
             */

            //examples of Converting:
            //dblNum1 = Int32.Parse(strNum1);
            //dblNum2 = Convert.ToInt32(strNum2);  

            //This will convert the string to an interger
            dblNum1 = Convert.ToDouble(strNum1); 
            dblNum2 = Convert.ToDouble(strNum2);

            // This is a fuction that would allow the operationals math to plaform.
            // Also the dblResult will stored the result of the adding, subtracting, multiplying and diviving the first
            // and the second number. 

            //This function will paused to check each breaking point of the points.
            //This break are a way to pause the console to see that the program does before running the whole program.
            switch (strOperand)
            {
                case "PLUS":
                    dblResult = dblNum1 + dblNum2;   //This is number 1 + the second number.

                    break;                           //This will stop the conditional statement.

                case "MINUS":

                    dblResult = dblNum1 - dblNum2;  //This is number first number - the second number.

                    break;                          //This will stop the conditional statement.

                case "MULTIPLY":

                    dblResult = dblNum1 * dblNum2;  //This is number first number * the second number.

                    break;                         //This will stop the conditional statement.

                case "DIVIDE":

                    dblResult = dblNum1 / dblNum2;  //This is number first number / the second number.

                    break;                         //This will stop the conditional statement.

            }

            //dblResult = (Double)intResult; This is the another way of using DOUBLE*

            //Here we have the 'if and else if' statements that will display the right operational calculation so the users get the ansawer that they are looking for. 

            if (strOperand == "PLUS") /*This conditional statement add the numbers together.
                                       Also this will output the answer on the console.*/ 
              
            {   //This is like print statements in python.
                //WE format by using the plus+ sing.
                //Also This will the display the final results.
                Console.WriteLine("\n\nThe answer of " + dblNum1 + "Pluse" + dblNum2 + "equeals = " + dblResult); 
                

            }

            else if (strOperand == "MINUS") //This will subtract the numbers and output the results.
   
            {   //This will displays the answers. 
                Console.WriteLine($"\n\nThe Answer of {dblNum1} minus {dblNum2} equals: {dblResult}");

            }

            else if (strOperand == "MULTIPLY") //This is multiplying the number together.
                
            {   //This is the display for the answer of multiplication. 
                Console.WriteLine($"\n\nThe Answer of {dblNum1} Multiply by {dblNum2} equals: {dblResult}");
            }
             
            else if (strOperand == "DIVIDE") //This is the division funtion. 

            {   //This not only display the answer but it allows the program to read it on the console.
                Console.WriteLine($"\n\nThe Answer of {dblNum1} Divide by {dblNum2} equals: {dblResult}");
            }
             //This will extit the program
            Console.WriteLine("\n\nPress enter to continue...");
            Console.ReadKey(); //It would read the key intruction. 


            
        }
    }
}
