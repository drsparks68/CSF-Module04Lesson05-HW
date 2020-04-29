using People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Homework: Create a class file and change the namespace to something different.  Call a method in that class.

            PersonModel testperson = new PersonModel();

            testperson.FirstName = "Molly";
            testperson.LastName = "Dolly";
            testperson.BirthDate = System.DateTime.Today;

            Console.WriteLine($"{ testperson.FullInfo }");

            Console.ReadLine();
        }
    }
}
