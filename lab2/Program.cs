using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Berta M. Puello-Martinez
// Date: 10/20/2021
// Course: SE245.03 C#
// Instructor: Scott Lambert
// Lab 2 assigments

/*This program will allow users to enter their full name and five labs grade.
Each grade will be added and divided by the number of grades entered, which is five. 
The information will be stored. After the program will display back to the user all info such as the grades entered, final grades, and the average grade of each labs.
The program also will allow the user to enter as much info as they want following the questions. The program will end when the user like.
 */

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            //This are my strings. "fullmanes" means full name. 'labone' is a string for lab number one and so on with the rest of the labs.
            //Lettergrades is the letter of the grade that the student get after being divided by five, the total amount of grades. "Lettergrades" is also an empty string that has
            // to be empty in order to work.
            // "answer" is the key wof the while loop, witch equials to
            String fulltname, labone, labTwo, labThree, labFour, labFive, Lettergrades="", answer; 

            //This are the doubles that my stings will be converted. Each labs and the numbers match each oder.
            double TotalLab1 = 0, TotalLab2 = 0, TotalLab3 = 0, TotalLab4 = 0, TotalLab5 = 0; //total_labs; last
            Int32 intcntr = 0;
            bool blnReasul = false;
             
            //This is my empty list.
            List<String> fname = new List<String>(); //This is the empty list for full name
            List<double> lab1 = new List<double>(); //This is the empty list for Lab 1.
            List<double> lab2 = new List<double>(); //This is the empty list for Lab 2.
            List<double> lab3 = new List<double>(); //This is the empty list for Lab 3.
            List<double> lab4 = new List<double>(); //This is the empty list for Lab 4.
            List<double> lab5 = new List<double>(); //This is the empty list for Lab 5.

            //This is for the count. It will count the amount of time that the loop runs.
            int counter = 0;

            do
            {
                //We do not have to convet here beacause this is a string.
                //This will stored the Student Full name.

                Console.WriteLine("Hello There! Enter Your Name: "); //user input
                fulltname = Console.ReadLine(); //storing the user info
                fname.Add(fulltname); //This is adding to the new list 'fname'.

                
                Console.WriteLine("Enter your first Grade: "); // user input
                labone = Console.ReadLine(); //storing the user info
                double gradeone = Convert.ToDouble(labone); //Here we are converting the string.
                lab1.Add(gradeone); // This is addiing it to the lab 1 new list.
                                        //This is for lab 2 grade.
                Console.WriteLine("Enter the Second Grade: "); //user input
                labTwo = Console.ReadLine();  //storing                 
                double gradetwo = Convert.ToDouble(labTwo);  //converting the string 
                lab2.Add(gradetwo); //adding to the list

                //This is for lab 3 grade.
                Console.WriteLine("Enter the third Grade"); //user input
                labThree = Console.ReadLine();   //storing the user info
                double gradethree = Convert.ToDouble(labThree); //converting
                lab3.Add(gradethree);  //adding to the list

                //This is lab 4 info
                Console.WriteLine("Enter the Fouth Grade"); // user info
                labFour = Console.ReadLine(); //storing
                double gradefour = Convert.ToDouble(labFour); //converting the string
                lab4.Add(gradefour); //adding to the list

                //This is lab 5 info.
                Console.WriteLine("Enter the Fifth Grade"); //user info
                labFive = Console.ReadLine(); //storing the info entered
                double gradefive = Convert.ToDouble(labFive); //convertng the string
                lab5.Add(gradefive); //adding to the list

                //This will ask the user if they would like to enter more info.
                //If they do not want to enter any more info, this will exit the user from the loop
                Console.WriteLine("Do you want to add another student? Enter [y/n]");
                answer = Console.ReadLine().ToUpper(); //storing capital
                                                        //answer = read the line


                //This will count the number of times that the loop runs.
                //Counter will be to divided the labs by so we can display the student average grade.
                counter += 1;
        
               
             //This the while loop and the answer "y" meaning Yes. If the user types 'y' the loop will run again. 
            } while (answer == "Y");


            
            //This is a for loop that will displsy the info stored such as full name and each labs.
            for (int i = 0; i < counter; i++){


                //This will display the each full names that are stored in to the list.
                Console.WriteLine($"\nFull Name: {fname[i]}");  
                //This will displays each each students labs.
                Console.WriteLine($"Lab 1:{lab1[i]}\nLab2: {lab2[i]}\nLab3: {lab3[i]}\nLab4: {lab4[i]}\nLab5: {lab5[i]}");

                double dblavg = lab1[i] + lab2[i] + lab3[i] + lab4[i] + lab5[i];  //Here we are adding all the labs.
                double gradesCal = dblavg / 5; //This is a new grade calculation.

                //This are the conditionals staments that calculate for the letter for each grades, 'A', 'B', 'C', 'D', and 'F'. 
                if (gradesCal < 60 )  //This is "F".
                {
                    Lettergrades = "F"; 
                }
                else if(gradesCal < 70) //This is 'D'.
                {
                    Lettergrades = "D";
                }

                else if(gradesCal < 80)  //This is "C"
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

            //This is the calculation for the average of all lab 1.
            for (int i = 0 ; i < counter; i++){ //Initially
                TotalLab1 += lab1[i] / counter;  //Here we are adding the total lab 1 and dividing for it count.

                
            }
            
            //This is the calculation for the average of labs 2. 
            for (int i = 0; i < counter; i++)
            {
                TotalLab2 += lab2[i] / counter; //Here we add and didvide by the total of count. 

             
            }
            //This is the calculation for the average of labs 3. 
            for (int i = 0; i < counter; i++)
            {
                TotalLab3 += lab3[i] / counter; //Here we are adding for the total of labs 3 and didviding it by its count.

                

            }

            //This is the calculation for the average of labs 4. 
            for (int i = 0; i < counter; i++)
            {
                TotalLab4 += lab4[i] / counter; //Here we are adding for the total of labs 4 and didviding it by its count.

                //Console.WriteLine(TotalLab4);
            }

            //This is the calculation for the average of labs 5. 

            for (int i = 0; i < counter; i++)
            {
                TotalLab5 += lab5[i] / counter; //Here we are adding for the total of labs 5 and didviding it by its count.

            }



            //This is the fianla dispalys for the average of each labs individually.
            //REMEMBER: In oder for this to work, it has to be ouside the loop. 
            Console.WriteLine($"\nlabs1: {TotalLab1} | labs2: {TotalLab2} | labs3: {TotalLab3} | labs4: {TotalLab4} | labs5: {TotalLab5}");

            //REMEMBER:
            //This will read the program. If this is commented out the program will not run.
            Console.ReadKey(); 

        }
    }
}
