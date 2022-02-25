using System; //  Lirbraries

namespace AIUB_LABTASK
{
    class Initial_File // A container where we can write our functions and objects
    {
        private const char V = '+';

        static void Main(string[] args)
        {
            
            // Variables
            string name = "Sudipta Kumar Das";
            int age = 22;

            Console.WriteLine("My name is " + name);
            Console.WriteLine("I am " + age + " Years Old "); // String Interpolation
            age = 18;
            Console.WriteLine("I do not like being " + age + " Years old");

            string developerName = "Sudipta Kumar Das";
            char developerGrade = 'A';
            int developerAge = 22;
            double developerSalary = 100000.00;
            bool isEligible = true;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Hello I am " + developerName);
            Console.WriteLine("My Grade is " + developerGrade);
            Console.WriteLine("I am  " + developerAge + " years old");
            Console.WriteLine("My Salary is =  " + developerSalary);
            Console.WriteLine("Elegiblity = " + isEligible);

            Console.WriteLine(developerName.ToUpper());
            Console.WriteLine(developerName[3]);
            Console.WriteLine(developerName.Substring(10)); // start from index 10 and write the rest
            Console.WriteLine(developerName.Substring(10, 3)); // start from index 10 and write next 3 characters

            Console.WriteLine(Math.Round(1.4));
            

            


        }
    }
}
