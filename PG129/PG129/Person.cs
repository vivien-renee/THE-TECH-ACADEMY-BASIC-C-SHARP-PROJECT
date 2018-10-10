using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG129
{
    public abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public abstract void SayName();

        public static bool operator ==(Employee employee, Person person)
        {
            if (employee.ID == employee.ID)
                return true;
            else
                return false;
        }

        public static bool operator !=(Employee employee, Person person)
        {
            if (employee.ID != employee.ID)
                return true;
            else
                return false;
        }



        public override bool Equals(object obj)
        {
            var person = obj as Person;
            return person != null &&
                   firstName == person.firstName &&
                   lastName == person.lastName;
        }

        public override int GetHashCode()
        {
            var hashCode = 545635260;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(firstName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(lastName);
            return hashCode;
        }
    }
}
