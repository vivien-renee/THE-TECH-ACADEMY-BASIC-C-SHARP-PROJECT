using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PG154
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number.");
            string text = Console.ReadLine();
            File.WriteAllText(@"C:\Users\christopher benben\Desktop\C#\C.txt", text);
            System.Console.WriteLine("{0} has been logged.", text);
            Console.ReadLine();

        }
    }
}
