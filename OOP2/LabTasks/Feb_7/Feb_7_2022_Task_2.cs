using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIUB_LABTASK
{
    class Feb_7_2022_Task_2
    {

        public static bool isWhole(double value)
        {
            if (Math.Floor(value) == Math.Ceiling(value))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("############################ Whole Number Checker #################################");
            Console.Write("Enter Number : ");
            double value = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Given Value is a whole Number = " + Feb_7_2022_Task_2.isWhole(value));
            Console.ReadKey(); // IT'll pause the generated last extra lines
        }
    }
}
