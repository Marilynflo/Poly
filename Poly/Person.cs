using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public abstract class Person
    {
        public string FirstName;
        public string LastName;
        public abstract void SayName();
    }

    public class Employees : Person, IQuittable
    {

        public void Quit()
        {
            Console.WriteLine("Goodbye");
        }
        public override void SayName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }
}