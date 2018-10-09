using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG131
{
    public class Employee <T> : Person, IQuittable
    {
        public List<T> Things { get; set; }
        

        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
        public void Quit()
        {
            Console.WriteLine("I Quit.");
        }
    }
}
