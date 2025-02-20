using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace App1
{
    class Program
    {   
        static void Main(string[] args)
        {
            // Example of static method in C# can be Math class
            // Math.Sqrt(144);
            // Math is a static class (i.e. object/instance of Math class cannot be created which is also useful).
            // and Sqrt() is a static method which means we don't have to create an object/instance of Math class to use it.

            // Demonstration using UsefulTools class
            UsefulTools.SayHi("Jacob");

            Console.ReadLine();
        }
    }
}
