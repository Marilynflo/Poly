using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public abstract class Person //creating a class with two string data types
    {
        public string FirstName; 
        public string LastName;
        public abstract void SayName();
    }

    public class Employees : Person, IQuittable// inheriting from Person, IQuitabble
    {

        public void Quit()
        {
            Console.WriteLine("Goodbye");
        }
        public override void SayName()
        {
            Console.WriteLine(FirstName + " " + LastName);//displaying the value on the console.
        }
    }
}
