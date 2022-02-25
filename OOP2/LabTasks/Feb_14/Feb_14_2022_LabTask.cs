using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIUB_LABTASK_C_SHARP
{
    class Feb_14_2022_LabTask
    {

        static int factorial(int num)
        {
            if (num == 1) return 1;
            else return num * factorial(num - 1);
        }

        static void fibonacciSeries(int num)
        {
            int num1 = 0;
            int num2 = 1;
            Console.Write($"{num1} {num2} ");
            for (int i = 0; i < num; i++)
            {
                int num3 = num1 + num2;
                num1 = num2;
                num2 = num3;
                Console.Write(num3 + " ");
            }
        }

        static bool checkPrime(int num)
        {
            for(int i = 2; i < num; i++)
            {
                if (num % i == 0) return false;
                else return true;
            }
            return false;
        }

        static int sumOfDigits(int num)
        {
            int result = 0;
            while (num != 0)
            {
                result += num % 10;
                num /= 10;
            }

            return result;
        }


        static void Main(string[] args)
        {
            
            while (true)
            {
                Console.WriteLine("1. Calculate Factorial");
                Console.WriteLine("2. Fibonacci Sequence");
                Console.WriteLine("3. Prime Checker");
                Console.WriteLine("4. sum of the digits");
                Console.Write("Enter Your Choice =>> ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        {
                            Console.Write("Enter The Number :");
                            int num = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"Factorial of {num} = " + factorial(num));
                            break;
                        }
                    case 2:
                        {
                            Console.Write("Enter The Number :");
                            int num = Convert.ToInt32(Console.ReadLine());
                            fibonacciSeries(num);
                            break;
                        }
                    case 3:
                        {
                            Console.Write("Enter The Number :");
                            int num = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"{num} is Prime = " + checkPrime(num));
                            break;
                        }
                    case 4:
                        {
                            Console.Write("Enter The Number :");
                            int num = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"Sum of all digits of {num} = " + sumOfDigits(num));
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Enter a Valid Choice !!");
                            break;
                        }
                }
                Console.Write("\nPress 1 to run again >> ");
                int run = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n\n");
                if (run != 1) break; 
            }

        }
    }
}
