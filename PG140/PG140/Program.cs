using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG140
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeeList = new List<Employee>();
            employeeList.Add(new Employee
            { FirstName = "John", LastName = "Smith", ID = 1 });

            employeeList.Add(new Employee
            { FirstName = "Joan", LastName = "Johnson", ID = 2 });

            employeeList.Add(new Employee
            { FirstName = "Joe", LastName = "White", ID = 3 });

            employeeList.Add(new Employee
            { FirstName = "Bob", LastName = "Black", ID = 4 });

            employeeList.Add(new Employee
            { FirstName = "Joe", LastName = "Red", ID = 5 });

            employeeList.Add(new Employee
            { FirstName = "Barbraanne", LastName = "Blue", ID = 6 });

            employeeList.Add(new Employee
            { FirstName = "Todd", LastName = "Cheese", ID = 7 });

            employeeList.Add(new Employee
            { FirstName = "Tanya", LastName = "Tree", ID = 8 });

            employeeList.Add(new Employee
            { FirstName = "Alex", LastName = "Shoe", ID = 9 });

            employeeList.Add(new Employee
            { FirstName = "Apple", LastName = "Cat", ID = 10 });



            foreach (Employee employee in employeeList)

            {
                if (employee.FirstName == "Joe")
                { employee.SayName(); }


            }


            List<Employee> NewEmployeeList = employeeList.Where(x => x.FirstName == "Joe").ToList();


            foreach (Employee employee in NewEmployeeList)
            { employee.SayName(); }


            List<Employee> NewIDList = employeeList.Where(x => x.ID > 5).ToList();

            foreach (Employee employee in NewIDList)
                { employee.SayName(); }




                Console.ReadLine();

        }

        public class Employee
        {


            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int ID { get; set; }

            public void SayName() 
            {



                {
                    Console.WriteLine(FirstName + " " + LastName + " " + ID);

                }


            }

        }
    }
}

