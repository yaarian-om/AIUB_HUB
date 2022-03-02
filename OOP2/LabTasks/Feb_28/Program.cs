using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIUB_LABTASK
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book("Sall Like Crazy","Sabre subr","101","Business", 1);
            b1.showInfo();
            Console.WriteLine("\n\n");
            Contact c1 = new Contact();
            c1.PersonId = "101";
            c1.PersonName = "Sudipta Kumar Das";
            c1.MobileNumber = "01931117419";
            c1.Age = 22;
            c1.Gender = 'M';
            c1.showPersonInfo();

            Console.ReadKey();
        }
    }
}
