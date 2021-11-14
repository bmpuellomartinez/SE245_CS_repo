using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puello_Lab4
{
    class Program
    {

        //Create strings for the person using 'private string'. Then, change form 'public' to 'private'. 
        //Create class hold for the personal data using 'private string'.
        //Create the variables for each data such as First name, Etc...
        public class Person
        {
            private string fName;  //This is for the first name.
            private string MName;  //This is for middle name.
            private string LName;  //This is for  last name.
            //Create Street one

            //Address info the user. 
            private string fStreet;  
            //create Stree two
            private string Sstreet;  
            //Create City  
            private string City;    
            //Create State
            private string State;
            //Create ZipCode
            private string Zip;
            //Create Phone
            private string Phone;
            //Create Email
            private string email;


            //From HERE Down:
            //Public each private string into a new variable with 'Get' and 'Set' and returning the value back.             
            public string FirstN //New Variable Name
            {
                get
                {
                    return fName;
                }
                set
                {
                    fName = value;
                }
            }

            public string MiddleN //New Variable Name
            {
                get
                {
                    return MName;
                }
                set
                {
                    MName = value;
                }
            }
            public string LastN //New Variable Name
            {
                get
                {
                    return LName;
                }
                set
                {
                    LName = value;
                }
            }

            public string FirstS //New Variable Name
            {
                get
                {
                    return fStreet;
                }
                set
                {
                    fStreet = value;
                }
            }
            public string SecondS //New Variable Name
            {
                get
                {
                    return Sstreet;
                }
                set
                {
                    Sstreet = value;
                }
            }

            public string city //New Variable Name
            {
                get
                {
                    return City;

                }
                set
                {
                    City = value;
                }
            }
            public string state //New Variable Name
            {
                get
                {
                    return State;
                }
                set
                {
                    State = value;
                }
            }
            public string zip //New Variable Name
            {
                get
                {
                    return Zip;

                }
                set
                {
                    Zip = value;
                }
            }

            public string phoneN //New Variable Name
            {
                get
                {
                    return Phone;

                }
                set
                {
                    Phone = value;
                }
            }
            public string Email //New Variable Name
            {
                get
                {
                    return email;
                }
                set
                {
                    email = value;
                }
            }
        }



        static void Main(string[] args)
        {
            // In the Main Function, Pass the Person class into a new variable called 'tPerson'...
            Person tPerson = new Person(); //tPerson is the new Person in here

            // Console each variable holder private using the new name private variable name.
            // Add on the console, '+Poopy so the world gets displayed with the output.
            Console.WriteLine("Pleas enter the person first Name: ");
            tPerson.FirstN = Console.ReadLine(); //New Variable Name
            tPerson.FirstN += "Poope";

            Console.WriteLine("Pleas enter the person Middle Name: ");
            tPerson.MiddleN = Console.ReadLine(); //New Variable Name
            

            Console.WriteLine("Pleas enter the person Last Name: ");
            tPerson.LastN = Console.ReadLine(); //New Variable Name
           

            Console.WriteLine("Pleas Enter the person First Street Name: ");
            tPerson.FirstS = Console.ReadLine(); //New Variable Name
            


            Console.WriteLine("Pleas Enter the person SECOND Street Name: ");
            tPerson.SecondS = Console.ReadLine(); //New Variable Name
            

            Console.WriteLine("Pleas Enter the Person City's Name: ");
            tPerson.city = Console.ReadLine(); //New Variable Name
            

            Console.WriteLine("Pleas Enter the Person State's Name: ");
            tPerson.state = Console.ReadLine(); //New Variable Name
            

            Console.WriteLine("Enter your ZipCode: ");
            tPerson.zip = Console.ReadLine(); //New Variable Name
            

            Console.WriteLine("Pleas Enter the person's Phone Number: ");
            tPerson.phoneN = Console.ReadLine(); //New Variable Name
            

            Console.WriteLine("Pleas Enter the person Email: ");
            tPerson.Email = Console.ReadLine(); //New Variable Name
            

            //Display each person info 
            Console.WriteLine($"\nNew Menber: {tPerson.FirstN} {tPerson.MiddleN} {tPerson.LastN}\nAddress: {tPerson.FirstN} {tPerson.SecondS} {tPerson.city} {tPerson.state}, {tPerson.zip}.\nPhone: {tPerson.phoneN}\nemail: {tPerson.Email}");


            // Call the BasicTool for pause() and so it display output
            BasicTools.Pause();

            BasicTools.PrintCopyright();

            //###############################################################################################################
            //NOTES: 
            // A class can have two different functions instenss of an object. Classes are to give the avility to do multiple things.
            //we are goint to create, validate and store date. We are going to crate classes so we can create object.
            //Classes to struction 

            //Create Prive: Other people does not mess with your stuff public class

            //Example :Person   Add<-- Persom:
            // Here we can add         FName
            // More info such as       MName:
            // credit card             LName
            //                         ECT










        }
    }
}
