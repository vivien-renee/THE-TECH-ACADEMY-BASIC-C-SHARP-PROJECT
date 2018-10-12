using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PG156
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Pick a number.");
            int number = Convert.ToInt32(Console.ReadLine());
            DateTime dt = DateTime.Now;
            dt = dt.AddHours(number);
            Console.WriteLine("In " + number + " Hour/s, it will be "+ dt);
            Console.ReadLine();
        }
    }
}
