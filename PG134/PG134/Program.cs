using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG134
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Please enter the current day of the week.");
                var currentDay = Enum.Parse(typeof(DaysOfTheWeek), Console.ReadLine());
            }

            catch (Exception)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }

            finally
            {
                Console.ReadLine();
            }
           
                
        }

        public enum DaysOfTheWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
    }
}
