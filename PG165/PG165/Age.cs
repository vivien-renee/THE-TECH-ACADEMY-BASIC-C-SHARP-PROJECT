using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG165
{
    public class Age
    {

        public void findYear ()

        {
            bool validAnswer = false;
            int age = 0;
            while (!validAnswer)
            {
                Console.WriteLine("What is your age?");
                //int age = Convert.ToInt32(Console.ReadLine());
                validAnswer = int.TryParse(Console.ReadLine(), out age);
                if (!validAnswer) Console.WriteLine("That's not a valid number, try again later");
            }

            if (age < 0)
            {
                throw new ArgumentException();
            }

            if (age < 1)
            {
                throw new Exception();
            }

            




            var yearToday = DateTime.Now.Year;

            int yearBorn = yearToday - age;

            Console.WriteLine("You were born in " + yearBorn);

        }




    }
}
