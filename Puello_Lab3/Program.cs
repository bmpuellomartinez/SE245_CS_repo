using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Berta M. Puello-Martinez
// Date: 10/26/2021
// Course: SE245.03 C#
// Instructor: Scott Lambert
// Lab 3 assigments

/*This program will allow users to enter their full name and five labs grade.
Each grade will be added and divided by the number of grades entered, which is five. 
The information will be stored. After the program will display back to the user all info such as the grades entered, final grades, and the average grade of each labs.
The program also will allow the user to enter as much info as they want following the questions. The program will end when the user like.
 */

namespace Puello_Lab3
{

    class Program
    {

        static string GetfName() //This is a functio so the users enter their name. Later this will be store inside of an empty list. 
        {

            string fName;   //This is the name of the string.
            Console.WriteLine("Enter your name: ");   //output
            fName = Console.ReadLine();              //storing the info.


            //NOTES:
            // If this was a double it would be:
            // double Getlabs;
            // Console.WriteLine(Inf);
            //  A variable that is different than the function;
            // Name = Console.RedLine();
            //double.Parse(Console.ReadLine());

            return fName; //This is function return the value back to fName.
        }

        static double errortrap(string msg) //This fiction will be the error trap for the labs questions.
                                            //The function does all the work insted of using multiple do loop.
                                            //It is  a perimetor.
        {
            double dbllabscal; //Before anything I need to declear the double to the question get read as a number. 
            bool success = true;  //True is key for the functon to run, and it is declear ouside the do loop so it works. 
            
            do //This on do loop will do the job for all the labs entering.
            {   
                //IF success = false and it is comperacing equalt to equal true 
                //console.  the enter the right input 
 
                Console.WriteLine(msg); //Pasing down the values or storing
                string labscal = Console.ReadLine(); //passing down as a string 
                success = Double.TryParse(labscal, out dbllabscal); // Here this will make used that the users are entering a nunber and not a letter.

            } while(!success); // The key to run until the answer comes out to be true (success)


            return dbllabscal; //This function is a perimeter and it has a return value.
        }
         
        
        //This function does not have a retrun value. Here I am using the list so the value of each question gets store inside the empty list.
        // grade one is inside the List<double>lab1, and so on and on.....
        static void Getgrades(List<double> lab1, List<double> lab2, List<double> lab3, List<double> lab4, List<double> lab5)
        {
            
            double gradeone = errortrap("Enter your first Grade: ");  //This is the question for the first grade.
            lab1.Add(gradeone); //adding to the list
            
            double gradetwo = errortrap("Enter the second grade: ");  //This is for the second grade question.
            lab2.Add(gradetwo); //adding to the list

            double gradethree = errortrap("Enter the third Grade: "); //This is for the third grade entering 
            lab3.Add(gradethree); //adding to the list

            double gradefour = errortrap("Enter the Forth grade: "); //This is for the forth grade.
            lab4.Add(gradefour); //adding

            double gradefive = errortrap("Enter the fifth grade: "); //This is for the fifth grade.
            lab5.Add(gradefive); //adding
        }


        static double AveGrades( List<double> Tlabs, ref double counter) 
         //This is a ref function and it will do the math for the total grades averages.
         //This function has a return value so when it gets call, it does its job.                                                  
        {
            double TotalLabs = 0; 
            for (int i = 0; i < counter; i++)
            { //Initially
                TotalLabs += Tlabs[i];  //Here we are adding the total labs and dividing for it count so we can get the total average.
            }
            return TotalLabs / counter;
        } 



        static void Main(string[] args) //###################################################### Main Function.
        {
            List<String> fname = new List<String>(); //This is the empty list for full name
            List<double> lab1 = new List<double>(); //This is the empty list for Lab 1.
            List<double> lab2 = new List<double>(); //This is the empty list for Lab 2.
            List<double> lab3 = new List<double>(); //This is the empty list for Lab 3.
            List<double> lab4 = new List<double>(); //This is the empty list for Lab 4.
            List<double> lab5 = new List<double>(); //This is the empty list for Lab 5.
            List<Int32> Tlabs = new List<Int32>();  //This is the empty list for the 'LABS AVEG'.


            //This are the strings
            string  answer = "", tname, Lettergrades = ""; //some of them are empty so the ansewer gets read later in the program.

            //This are my doubles variables for each labs and counter, all declear as Zero.
            double counter = 0, TotalLab1 = 0, TotalLab2 = 0, TotalLab3 = 0, TotalLab4 = 0, TotalLab5 = 0;

            do
            {

                //In here I am calling the functions and passing it down to a new variable.
                tname = GetfName(); //Calling the name fuction.
                fname.Add(tname);   //Storing the name function into a new container.
                Getgrades(lab1, lab2, lab3, lab4, lab5);  //Parameter 


                //Asking the user, if they would like to enter more DATA!
                Console.WriteLine("Do you want to add another student? Enter [y/n]");
                answer = Console.ReadLine().ToUpper(); //storing into capital
                                                       //answer = read the line
                //This is the counter and it is also used in the ref function.
                counter += 1;

            } while (answer == "Y");    //This has to be == in order to work! Also the Y means yes.

            for (int i = 0; i < counter; i++) //This for loop will display the all the information entered
            {


                //This will display the each full names that are stored in to the list.
                Console.WriteLine($"\nFull Name: {fname[i]}");
                //This will displays each each students labs.
                Console.WriteLine($"Lab 1:{lab1[i]}\nLab2: {lab2[i]}\nLab3: {lab3[i]}\nLab4: {lab4[i]}\nLab5: {lab5[i]}");

                double dblavg = lab1[i] + lab2[i] + lab3[i] + lab4[i] + lab5[i];  //Here we are adding all the labs.
                double gradesCal = dblavg / 5; //This is a new grade calculation.

                //This are the conditionals staments that calculate for the letter for each grades, 'A', 'B', 'C', 'D', and 'F'. 
                if ( gradesCal < 60)  //This is "F".
                {
                    Lettergrades = "F";
                }
                else if (gradesCal < 70) //This is 'D'.
                {
                    Lettergrades = "D";
                }

                else if (gradesCal < 80)  //This is "C"
                {
                    Lettergrades = "C";

                }
                else if (gradesCal < 90) //This is a 'B'.
                {
                    Lettergrades = "B";
                }

                else
                {
                    Lettergrades = "A"; //This is 'A'.
                }

                //This will prit out the fianl grade with the letter that applys to it. 
                Console.Write($"Total grade: {gradesCal} \nGrade:{Lettergrades}");

            }

            //Here we are adding the total lab 1 and dividing for it count.
            //This is the calculation for the average of all lab 1.
            //Calling, passing the function into a new variable and using the ref as the labs and divding by the amount of student entered. 
            TotalLab1 = AveGrades(lab1, ref counter);  //This is for lab1 grade.
            TotalLab2 = AveGrades(lab2, ref counter);  //This is for lab two grade.
            TotalLab3 = AveGrades(lab3, ref counter);  //This is for lab three grade.
            TotalLab4 = AveGrades(lab4, ref counter);  //This is for lab for grade.
            TotalLab5 = AveGrades(lab5, ref counter);  //This is for lab five grade.


            //This is the fianla dispalys for the average of each labs individually.
            //REMEMBER: In oder for this to work, it has to be ouside the loop. 
            Console.WriteLine($"\nlabs1: {TotalLab1} | labs2: {TotalLab2} | labs3: {TotalLab3} | labs4: {TotalLab4} | labs5: {TotalLab5}");

            //REMEMBER:
            //This will read the program. If this is commented out the program will not run.
            Console.ReadKey();

        }
    }
}

         

            


            
        
