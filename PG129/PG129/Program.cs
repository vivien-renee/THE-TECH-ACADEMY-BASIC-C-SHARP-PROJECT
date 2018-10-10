using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG129
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee person = new Employee();
            person.firstName = "Sample";
            person.lastName = "Student";
            person.ID = 1;
            person.SayName();

            Employee person2 = new Employee();
            person.firstName = "Joan";
            person.lastName = "Smith";
            person.ID = 2;
            person.SayName();

            Console.WriteLine(1 == 2);

            Console.ReadLine();
        }


    }
}
