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

            // Console.WriteLine(31);
            // Console.WriteLine(-2);
            // Console.WriteLine(3.454);
            // Console.WriteLine(-3423.2424);
            // Console.WriteLine(5+8);

            // Mathematical operations on integer numbers returns an integer value
            // However, mathematical operations on decimal numbers returns a decimal value
            // If performing, mathematical operations on integer and decimal numbers then a double is returned
            // Console.WriteLine(5 / 2);
            // Console.WriteLine(5 / 2.0);

            int num = 6;
            num++; // adds 1 to the variable num | Output: 7
            num = 4;
            num--; // subtracts 1 from the variable num | Output: 3
            // Console.WriteLine(num);
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Math Operations");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Absolute: " + Math.Abs(-40)); // Returns absolute value (non-negative value of a number)
            Console.WriteLine("Power: " + Math.Pow(3, 2)); // Returns value of X^power | Output: 9
            Console.WriteLine("Square Root: " + Math.Sqrt(44)); // Returns square root of a number
            Console.WriteLine("Max: " + Math.Max(4, 90)); // Returns the bigger value
            Console.WriteLine("Min: " + Math.Min(7, 3)); // Returns the smaller value
            Console.WriteLine("Round: " + Math.Round(7.899)); // Rounds to the nearest value
            Console.ReadLine();

        }
    }
}
