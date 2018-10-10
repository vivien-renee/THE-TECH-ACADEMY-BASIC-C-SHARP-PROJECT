using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG137
{
    class Program
    {
        static void Main(string[] args)
        {
            Number firstNumber = new Number();
            firstNumber.Amount = 7.2m;
            Console.WriteLine(firstNumber.Amount);
            Console.ReadLine();
        }

        public struct Number
        {
            public decimal Amount { get; set; }
        }

    }   
}
