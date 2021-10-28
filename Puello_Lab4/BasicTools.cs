using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puello_Lab4
{
    class BasicTools
    {
        public static void Pause()
        {

            //Print a pront
            Console.WriteLine("\n\nPress the 'ENTER KEY' to continue");

            //Use imput  just to cause system to wait for the Enter key to be pressed. 
            Console.ReadLine();

        }


        public static void PrintCopyright()
        {
            Console.WriteLine($"\n\nCopy right Junto {DateTime.Today.Year}");
            Pause();

        }
    }
}
