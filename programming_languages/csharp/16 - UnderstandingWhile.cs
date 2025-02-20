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
            // A while loop repeatedly executes a set of instructions as long as a specified condition is true.
            // int i = 0;
            // Conditions are passed as parameters (boolean values allow looping)
            // while (i < 5) 
            // {
            //     Console.WriteLine("Test Succeeded");
            //     Increment operator increments the value of variable until the specified condition becomes false.
            //     i++; 
            // }

            int index = 1;

            while(index <= 5)
            {
                Console.WriteLine(index);
                index++;
            }

            // Infinite loop - a condition that never becomes false
            // So in previous example, if we remove 'index++;' then the condition will always be true.
            // And this is because we aren't modifying the value of index variable anymore.
            // And since this becomes the case, the while loop example will never stop printing value of index variable.

            Console.ReadLine();
        }
    }
}
