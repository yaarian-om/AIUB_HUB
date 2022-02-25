using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIUB_LABTASK
{
    class Feb_7_2022_Task_1
    {
        public static double usdToBDT(double dollar)
        {
            double BDT = 86.19;
            return dollar * BDT;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("############################ Dollar To BDT Converter #################################");
            Console.Write("Enter Dollar : ");
            double dollar = Convert.ToDouble(Console.ReadLine());
            double bdt = Feb_7_2022_Task_1.usdToBDT(dollar);
            Console.WriteLine("BDT = " + bdt + " TK/-");
            Console.ReadKey(); // IT'll pause the generated last extra lines

        }
        
    }
}
