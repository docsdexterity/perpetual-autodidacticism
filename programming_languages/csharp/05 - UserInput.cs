using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter your name: "); // .Write() allows the user to write the name in the same line
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            string age = Console.ReadLine();
            Console.WriteLine("Hey " + name + "! What's up?");
            Console.WriteLine("Congrats on turning " + age + " today...");

            Console.ReadLine();

        }
    }
}
