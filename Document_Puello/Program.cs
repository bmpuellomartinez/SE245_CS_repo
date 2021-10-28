using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// uisng System.Data; 

// Berta M. Puello-Martinez
// Date: 10/10/2021
// Course: SE245.03 C#
// Instructor: Scott Lambert
// Document assigments



namespace Document_Puello
{
    class Program //This is like an imported program. 
    {
        static void Main(string[] args) //This is the main fuction. 

        {
            String strFname, strNum1, strNum2; //This are strings. 
            Int32 intNum1 = 0, intNum2 = 0, intResult = 0; //string turned into integers. 
            
            Console.WriteLine("Hello There!");
            Console.Write("Enter your First Name: ");      // <---The user will have to enter his/her name here. "input"
            strFname = Console.ReadLine();


            Console.WriteLine("Hello," +strFname+ " \nThis is the Documentation assigment./n Press enter to continue.."); //This is the console display. 
            Console.ReadLine(); //This allowed the line to be read it on the consele.


            Console.WriteLine("Enter a number Number: "); //This an imput for the users. 
            strNum1 = Console.ReadLine();

            Console.Write("Enter the SECOND: ");
            strNum2 = Console.ReadLine();

            //examples for integers. We are onverting bellow
            intNum1 = Int32.Parse(strNum1);
            intNum2 = Convert.ToInt32(strNum2);

            intResult = intNum1 + intNum2; // This wiil add the both numbers together. It is a small math We could also used strOperand.

            Console.WriteLine("The answer is: " + intResult);
            Console.ReadLine();

            // This is a single line remark or comment (Two forward-slashes) 
            // Also If you try to comment on a new line, this will not work because it can only be used one line at a time. 

            /*
            * This is a multi-line.
            * comment.
            * Because these lines are between the open and close.
            This method will allow the progamer to make multiple comments as long as it is closed with
            The (asterisk and foward slash). 
            You do not have to used the (*) at the beginning of the line. The (*) is being used like a bold point.
            If you try to use asterik and the foward slashe insied of the original symbols it might not closed and it will 
            leave the other*/

            if ()
        }
    }
}
