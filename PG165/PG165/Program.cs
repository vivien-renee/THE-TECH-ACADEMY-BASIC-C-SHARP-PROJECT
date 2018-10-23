using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG165
{
    class Program
    {
        static void Main(string[] args)
        {

            Age age = new Age();


            try
            {
                age.findYear();
            }


            catch (ArgumentException)
            {
                Console.WriteLine("Please enter a positive number.");
                return;

            }

            catch (Exception)
            {
                Console.WriteLine("Please enter a whole number other than zero.");
                return;

            }

           



            finally
            {
                Console.ReadLine();
            }

            




        }
    }
}
