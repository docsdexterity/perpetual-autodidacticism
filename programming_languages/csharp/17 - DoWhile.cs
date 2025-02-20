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
            // A do-while loop repeatedly executes a set of instructions at least once (even if it's false,
            // and then continues to execute them as long as a specified condition is true.
            // E.g.

            int index = 6;

            // The code inside the loop is executed first and then the condition is checked.
            do
            {
                Console.WriteLine(index);
                index++;
                // Console.WriteLine(index);
            } while (index <= 5);

            Console.ReadLine();
        }
    }
}
