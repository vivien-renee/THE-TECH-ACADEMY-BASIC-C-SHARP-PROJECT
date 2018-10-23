using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG162
{
  

    public  class Person
    {

        public Person(string FirstName) : this(FirstName, "Unknown")
        {
        }

        public Person(string FirstName, string LastName)
        {
            firstName = FirstName;
            lastName = LastName;

        }


        public string firstName { get; set; }
        public string lastName { get; set; }
        public  void SayName()
        { Console.WriteLine("Name: " + firstName + " " + lastName); }
    }


    
    

}

