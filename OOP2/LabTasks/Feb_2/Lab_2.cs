using System; //  Lirbraries

namespace AIUB_LABTASK
{
    class Lab_2 // A container where we can write our functions and objects
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the First Number : ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the Second Number : ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double res = num1 + num2;
            Console.WriteLine("Addition of " + num1 + " + " + "" + num2 + " = " + res);
            res = num1 - num2;
            Console.WriteLine("Subtraction of " + num1 + " - " + "" + num2 + " = " + res);
            res = num1 * num2;
            Console.WriteLine("Multiplication of " + num1 + " X " + "" + num2 + " = " + res);
            res = num1 / num2;
            Console.WriteLine("Division of " + num1 + " / " + "" + num2 + " = " + res);
            res = num1 % num2;
            Console.WriteLine("Reminder of " + num1 + " % " + "" + num2 + " = " + res);


            Console.ReadKey();
        }
    }
}
