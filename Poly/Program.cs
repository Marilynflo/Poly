using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuittable employee = new Employees();// creating an employee object
            employee.Quit();

            Employees name = new Employees() { FirstName = "Sample", LastName = "Student" };//assigning values
            name.SayName();
            Console.ReadLine();
        }
    }
}
