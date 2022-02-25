using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIUB_LABTASK_C_SHARP.Feb_16
{
    class Feb_16_2022_LabTask_1
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
            else if (isStudent && !isMale && hasJob)
            {
                Console.WriteLine("The user is a female student and has a job");
            }
            else if (!isStudent && isMale && hasJob)
            {
                Console.WriteLine("The user is a male but not a student and has a job");
            }
            else if (isStudent && !isMale && !hasJob)
            {
                Console.WriteLine("The user is a female student and does not have a job");
            }
            else if (!isStudent && !isMale && !hasJob)
            {
                Console.WriteLine("The user is a female user and not a student and does not have a job");
            }
            else if (!isStudent && !isMale && hasJob)
            {
                Console.WriteLine("The user is a female but not a student and has a job");
            }
            else if (!isStudent && !isMale && hasJob)
            {
                Console.WriteLine("The user is a female but not a student and has a job");
            }
            else if (!isStudent && isMale && !hasJob)
            {
                Console.WriteLine("The user is a male but not a student and doesn't have a job");
            }
            else if (!isStudent && !isMale && !hasJob)
            {
                Console.WriteLine("The user is a female but not a student and doesn't have a job");
            }
            else if (isStudent && isMale || hasJob)
            {
                Console.WriteLine("The user is a male and a student or has a job");
            }
            else if (isStudent && isMale || !hasJob)
            {
                Console.WriteLine("The user is a male and a student or doesn't have a job");
            }
            else if (isStudent && !isMale || hasJob)
            {
                Console.WriteLine("The user is a female but not a student or has a job");
            }
            else if (!isStudent && isMale || hasJob)
            {
                Console.WriteLine("The user is a male but not a student or has a job");
            }
            else if (!isStudent && !isMale || hasJob)
            {
                Console.WriteLine("The user is a female but not a student or has a job");
            }
            else if (isStudent && !isMale || !hasJob)
            {
                Console.WriteLine("The user is a female a student or doesn't have a job");
            }
            else if (!isStudent && isMale || !hasJob)
            {
                Console.WriteLine("The user is a male and not a student or doesn't have a job");
            }
            else if (!isStudent && !isMale || !hasJob)
            {
                Console.WriteLine("The user is a female and not a student or doesn't have a job");
            }
            else if (isStudent || isMale || hasJob)
            {
                Console.WriteLine("The user is a male or a student or has a job");
            }
            else if (!isStudent || isMale || hasJob)
            {
                Console.WriteLine("The user is a male or not a student or has a job");
            }
            else if (isStudent || !isMale || hasJob)
            {
                Console.WriteLine("The user is a female or a student or has a job");
            }
            else if (isStudent || isMale || !hasJob)
            {
                Console.WriteLine("The user is a male or a student or doesn't have a job");
            }
            else if (isStudent || !isMale || !hasJob)
            {
                Console.WriteLine("The user is a female or a student or doesn't have a job");
            }
            else if (!isStudent || !isMale || !hasJob)
            {
                Console.WriteLine("The user is a female or not a student or doesn't have a job");
            }
            else if (!isStudent || isMale || !hasJob)
            {
                Console.WriteLine("The user is a male or not a student or doesn't have a job");
            }
            else if (!isStudent || !isMale || !hasJob)
            {
                Console.WriteLine("The user is a female or not a student or doesn't have a job");
            }
            else if (isStudent || isMale && hasJob)
            {
                Console.WriteLine("The user is a male or a student and has a job");
            }
            else if (isStudent || isMale && !hasJob)
            {
                Console.WriteLine("The user is a male or a student and doesn't have a job");
            }
            else if (isStudent || !isMale && hasJob)
            {
                Console.WriteLine("The user is a female or a student and has a job");
            }
            else if (!isStudent || isMale && hasJob)
            {
                Console.WriteLine("The user is a male or not a student and has a job");
            }
            else if (!isStudent || !isMale && hasJob)
            {
                Console.WriteLine("The user is a female or not a student and has a job");
            }
            else if (isStudent || !isMale && !hasJob)
            {
                Console.WriteLine("The user is a female or a student and doesn't have a job");
            }
            else if (!isStudent || isMale && !hasJob)
            {
                Console.WriteLine("The user is a male or not a student and doesn't have a job");
            }
            else if (!isStudent || !isMale && !hasJob)
            {
                Console.WriteLine("The user is a female or not a student and doesn't have a job");
            }
            else
            {
                Console.WriteLine("EEROR !!! PLEASE CHECK YOUR INPUTS");
            }
        }
    }
}
