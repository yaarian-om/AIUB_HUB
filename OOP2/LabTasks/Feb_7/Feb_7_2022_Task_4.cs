using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIUB_LABTASK
{
    class Feb_7_2022_Task_4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("############################ Check The Smallest Value #################################");
            Console.Write("Enter 1st Number : ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter 1st Number : ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double maxVal = Math.Min(num1, num2);
            Console.WriteLine("Min value = " + maxVal);
            Console.ReadKey(); // IT'll pause the generated last extra lines
        }
    }
}
