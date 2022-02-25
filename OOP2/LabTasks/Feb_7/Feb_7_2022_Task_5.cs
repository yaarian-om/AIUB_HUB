using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIUB_LABTASK
{
    class Feb_7_2022_Task_5
    {
        public static double circleArea(double radius)
        {
            double PI = 3.1416;
            return (PI * (Math.Pow(radius, 2)));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("############################ Circle Area Calculator #################################");
            Console.Write("Enter Radius (meter) : ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Circle Area = " + Feb_7_2022_Task_5.circleArea(radius) + " Sq. Meter");
            Console.ReadKey(); // IT'll pause the generated last extra lines
        }


    }
}
