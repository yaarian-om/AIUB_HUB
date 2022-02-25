using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIUB_LABTASK_C_SHARP.Feb_16
{
    class Feb_16_2022_ClassWork
    {
        static void Main(string[] args)
        {
            bool isStudent = false;
            bool isMale = true;
            bool hasJob = true;

            if (isStudent && isMale && hasJob)
            {
                Console.WriteLine("The user is a male student and has a job");
            }
            else if (isStudent && isMale && !hasJob)
            {
                Console.WriteLine("The user is a male student and does not have a job");
            }
            else if (isStudent || isMale || !hasJob)
            {
                Console.WriteLine("The user is a male student and does not have a job");
            }
            else if (isStudent || isMale || hasJob)
            {
                Console.WriteLine("The user is a male student and does not have a job");
            }
            else if (!isStudent && !isMale && hasJob)
            {
                Console.WriteLine("The user is a female but not a student and has a job");
            }
            else
            {
                Console.WriteLine("The user is either a student or male or both");
            }
        }
    }
}
