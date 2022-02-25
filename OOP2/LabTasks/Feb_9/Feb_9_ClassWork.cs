using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIUB_LABTASK_C_SHARP.Feb_9
{
    class Feb_9_ClassWork
    {
        static void MMA()
        {
            Console.WriteLine("Empty Parameter");
        }
        static void MMA(string name)
        {
            Console.WriteLine("Hello " + name);
        }
        static void MMA(string name, int age)
        {
            Console.WriteLine($"Your Name is {name} nad Age is {age}");
        }

        static void Main(string[] args)
        {
            #region Array Printing Using Loop
            /// Jagged Array
            int[,] XX = new int[3, 3] { 
                { 1, 2, 3 }, 
                { 4, 5, 6 }, 
                {7, 8, 9 } 
            };
            #endregion Array Printing Using Loop

            MMA();
            MMA("Yaarian");
            MMA("Yaarian",22);


            Console.ReadKey();
        }

        

    }
}
