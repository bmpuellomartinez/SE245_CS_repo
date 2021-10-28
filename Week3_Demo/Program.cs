using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Week3_Demo
{
    class Program
    {




            static void Pause()
            {
                Console.WriteLine("Press any key to continue: ");
                Console.ReadKey();

            }

             static void double CalcAveg(double dblTotal, int intNomoFpayckecks)
            {
                double dblResult = (dblTotal / intNomoFpayckecks);

                return dblResult;
            }
            static void DisplayTheList(List<double> dblListIncoming)
            {
                int intCntr = 1;
                foreach (double d in dblListIncoming)
                {
                    Console.WriteLine($"weekly entry #{intCntr}: ${d}");
                    intCntr++;
                }
            }


            static void StoreToTheList(List<double> dblEarnings, ref double dblTotal, ref int intCounter, double dblPaycheck)
            {
                dblEarnings.Add(dblPaycheck);
                dblTotal += dblPaycheck;
                intCounter++;

            }

            static bool IsValidDouble(String strNum)
            {
                double dblNum = 0;
                bool blnResult = Double.TryParse(strNum, out dblNum);

                return blnResult;
            }

            static void Main(string[] args)
            {
            string strFirst, strNum, strCntr;
            Double dblNum = 0, dblTotal = 0, dblResult = 0;
            Int32 intCntr = 0;
            bool dlbResult = false;



            }

            Pause;
  
        







    }
}
