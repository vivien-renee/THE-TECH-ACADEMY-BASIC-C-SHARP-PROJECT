using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG131
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee <string> strings = new Employee<string>();
            List<string> stringThings = new List<string>();
            stringThings.Add("one");
            stringThings.Add("two");
            stringThings.Add("three");
            strings.Things = stringThings;
            Employee<int> integers = new Employee<int>();
            List<int> integerThings = new List<int>();
            integerThings.Add(1);
            integerThings.Add(2);
            integerThings.Add(3);
            integers.Things = integerThings;


            for (int i = 0; i < stringThings.Count; i++)
            {
                Console.WriteLine(stringThings[i]);
            }

            for (int i = 0; i < integerThings.Count; i++)
            {
                Console.WriteLine(integerThings[i]);
            }



            //person.firstName = "Sample";
            //person.lastName = "Student";
            //person.SayName();

            //IQuittable quittable = new Employee();
            //quittable.Quit();

            Console.ReadLine();
        }
    }
}
