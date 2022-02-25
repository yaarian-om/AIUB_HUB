using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIUB_LABTASK_C_SHARP.Feb_14
{
    class Feb_14_2022__ClassWork
    {
        static int cube(int num)
        {
            int result = num * num * num;
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(cube(5));
        }
    }
}
