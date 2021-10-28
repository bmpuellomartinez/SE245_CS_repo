using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puello_Lab4
{
    class Program
    {
        public class Person
        {
            private string fName;  //This is for the first name.
            private string MName;  //This is for middle name.
            private string LName;  //
            //Create Street one
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


            public string FirstN
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

            public string MiddleN
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
            public string LastN
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

            public string FirstS
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
            public string SecondS
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

            public string city
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
            public string state
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
            public string zip
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

            public string phoneN
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
            public string Email
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
            //create a person name 
            Person tPerson = new Person();

            //get date fill person
            Console.WriteLine("Pleas enter the person first Name: ");
            tPerson.FirstN = Console.ReadLine();

            tPerson.FirstN += "Poopy";

            Console.WriteLine("Pleas enter the person Middle Name: ");
            tPerson.MiddleN = Console.ReadLine();
            tPerson.MiddleN += "Poopy";

            Console.WriteLine("Pleas enter the person Last Name: ");
            tPerson.LastN = Console.ReadLine();
            tPerson.LastN += "Poopy";

            Console.WriteLine("Pleas Enter the person First Street Name: ");
            tPerson.FirstS = Console.ReadLine();
            tPerson.FirstS += "Poopy";


            Console.WriteLine("Pleas Enter the person SECOND Street Name: ");
            tPerson.SecondS = Console.ReadLine() + "Poopy";
            tPerson.SecondS += "Poopy";

            Console.WriteLine("Pleas Enter the Person City's Name: ");
            tPerson.city = Console.ReadLine();
            tPerson.city += "Poopy";

            Console.WriteLine("Pleas Enter the Person State's Name: ");
            tPerson.state = Console.ReadLine();
            tPerson.state += "Poopy";

            Console.WriteLine("Enter your ZipCode: ");
            tPerson.zip = Console.ReadLine();
            tPerson.zip += "Poopy";

            Console.WriteLine("Pleas Enter the person's Phone Number: ");
            tPerson.phoneN = Console.ReadLine();
            tPerson.phoneN += "Poopy";

            Console.WriteLine("Pleas Enter the person Email: ");
            tPerson.Email = Console.ReadLine();
            tPerson.Email += "Poopy";


            //Output peroson data                     Continue with the rest of it. 
            Console.WriteLine($"\nNew Menber: {tPerson.FirstN} {tPerson.MiddleN} {tPerson.LastN}\nAddress: {tPerson.FirstN} {tPerson.SecondS} {tPerson.city} {tPerson.state}, {tPerson.zip}.\nPhone: {tPerson.phoneN}\nemail: {tPerson.Email}");
           
            //Let the user deside when they are done with the program.
            BasicTools .Pause();

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
