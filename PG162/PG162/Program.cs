using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG162
{
    class Program
    {
        static void Main(string[] args)
        {
            
            const string BossName = "Vivien";
            Console.WriteLine("The boss today is {0}", BossName);
            var person = new Person("Bob"/*, "Bobber"*/);
            person.SayName();

            

            Console.ReadLine();
         
        }
    }
}
