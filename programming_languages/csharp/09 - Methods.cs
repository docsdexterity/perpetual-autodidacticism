using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class Program
    {   

        // static --> keyword
        // void   --> return type
        // Main   --> method's name
        static void Main(string[] args)
        {

            // A method is just a block of code inside a container which can be called to perform a specific task
            // Note: Functions and Methods are closely related but they are not same.
            // This is because a function is a reusable code that isn't tied to any class or object.
            // However, a method can be tied to a class or object and has to be explicitly called in order to work.

            // SayHi();

            // Any value or information given to a method/function is called a parameter.
            // And, a parameter is defined in the parenthesis of that method/function.
            // E.g.

            // SayHi("John");

            // There can be more parameters as well.
            // E.g.

            SayHi("John", 35);
            Console.ReadLine();          

        }

        // Capitalizing the first letter in method's name is a naming convention in C#
        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hello " + name + "! You are " + age + " years old.");
        }
    }
}
