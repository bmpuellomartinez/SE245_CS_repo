using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// uisng System.Data; 

// Berta M. Puello-Martinez
// Date: 10/12/2021
// Course: SE245.03 C#
// Instructor: Scott Lambert
// Document assigments

/*
This prgram will allow the user to check their final grade score. First, the users will have to enter four grades.
Based on theirgrades score that they enter, the program will verify their final grade.
The grade will be divided by 4 which is the average of the four total grades.
After the data is enter, the result will be display and it will let the user know their final grade.
 */

namespace Week_2assignment
{
    class Program
    {
        static void Main(string[] args) //This is the main Function.
        {
            //This are my variables
            string strFname, strNum1, strNum2, strNum3, strNum4;

            //New int so we later can converted from string into integers,
            Double  Num1 = 0, Num2 = 0, Num3 = 0, Num4 = 0, sumG = 0, fgrade = 0;

            //This will be used to divide the four grades entered by the users.
            Int32  Num5 = 4; 

            //This is a hello message
            Console.WriteLine("Hello There!. \nLets check your grade score.");

            //This will allow the user to enter their name.
            Console.WriteLine("Pleas! Enter Your Name: ");
            strFname = Console.ReadLine();     //<-- reading on the console

            // strfname is the variable for the users Name.
            // Also it will be stored and print out back to the user.
            Console.WriteLine("Hello there !" + strFname + "\nPleas Follow the next avalable instructions.");

            //This will allow the users to enter their first grade.
            Console.WriteLine("\nPleas Enter the first Grade: ");
            strNum1 = Console.ReadLine();  //<-- reading back on the console             

           //This is allow the users to enter their second grade.
            Console.WriteLine("Enter your second grade: ");
            strNum2 = Console.ReadLine(); //<-- reading back to the console

            //This will allow the users to enter their third grade.
            Console.WriteLine("Enter Your third grade: ");
            strNum3 = Console.ReadLine(); //reading back to the console

            //This will allow the users to enter their last grade. 
            Console.WriteLine("Enter Your fourth grade: ");
            strNum4 = Console.ReadLine();  //<-- reading back to the console
             
            //Heere we are comverting out strings to integers!
            Num1 = Double.Parse(strNum1); //First grade
            Num2 = Double.Parse(strNum2); //Second grade
            Num3 = Double.Parse(strNum3); //Third grade
            Num4 = Double.Parse(strNum4); //Last grade


            //Here we are trying to add the grades together so we can come up with the final grade.
            //We are adding all the grades.
            sumG = Num1 + Num2 + Num3 + Num4 ; 

            //Here we are diving the grades by 4. Which the amont of grade entered by the users.
            //This will display the final answer. 
            fgrade = sumG / Num5;

            //This are the if and else if statement that will determined the final grade of the users.
            //This will go the lowest to the highest. 
            // The console.Write() will display the Final answers.


            //We need to stored the informarion with listd, rays 

            if (fgrade < 60)  //Last than 60 is a "F"
            {

                Console.WriteLine($"\nYour Final Grade is: {fgrade} \nThat's a 'F'.\nPleas talk with your instructor.");

            }

            else if (fgrade < 70) //Last than 70 is a "D"
            {


                Console.WriteLine($"\nYour Final Grade is: {fgrade} \nGrade: 'D'.\nYou are in Danger");

                Console.WriteLine("PLEAS! Talk with your Instructor.");

            }
            else if (fgrade < 80) //Last than 80 is a "C"
            {

                Console.WriteLine($"Your Grade Is {fgrade} \n Grade: 'C'.");

            }

            else if (fgrade < 90)  //Last than 90 is a "B"
            {

                Console.WriteLine($"Your Grade is a {fgrade}. \nGrade: 'B'.");

            }
            else   //If the final grade is greater than 90, it will be an "A".         
            {
                 
                Console.WriteLine($"Your Grade is an {fgrade} .Grade: 'A'.");

            }
           
            Console.WriteLine("Press any key to exit"); //Thid will Exit the users from the program!
            Console.ReadKey();



        }
    }
}
