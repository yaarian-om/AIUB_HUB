using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIUB_LABTASK_C_SHARP.Feb_9
{
    class Feb_9_2022_Task_1
    {
        static void Main(string[] args)
        {
            #region Variables
            int size;
            int total = 0;
            #endregion Variables

            #region Array Declaration & User Input
            Console.Write("Enter How Many Numbers to input : ");
            size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
            array[0] = 419; // Manual Input
            Console.WriteLine("Manual Input Print = " + array[0]);
            // Storing Data
            for(int i = 0; i < size; i++)
            {
                Console.Write($"Enter element {i+1} : ");
                array[i] = Convert.ToInt32(Console.ReadLine());
                total = total + array[i];
            }
            #endregion Array Declaration & User Input

            #region Reverse Print
            Console.Write("Printing Reverse Order = ");
            for (int i = size - 1; i >= 0; i--)
            {
                Console.Write(array[i] + " ");
            }
            #endregion Reverse Print
            Console.WriteLine("\nSum of all elements of that array = "+total);
            Console.ReadKey(); // holds The Console for not printing extra lines
        }
    }
}
