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
            // An exponent function takes in two numbers i.e base number & a power number,
            // and it will take the base number to the power number

            Console.WriteLine("-----------------------------");
            Console.WriteLine("Calculating Exponents");
            Console.WriteLine("-----------------------------\n");

            Console.Write("Enter base number: ");
            int baseNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter power number: ");
            int powNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Result: " + GetPow(baseNum, powNum));          
            Console.ReadLine();
        }

        static int GetPow(int baseNum, int powNum)
        {
            int result = 1;

            for (int i = 0; i < powNum; i++)
            {
                result *= baseNum; // equivalent to result = result = result * baseNum
                // let's say baseNum = 2 and powNum = 3
                // so for first iteration --> result = 1 * 2 (i.e. 2)
                // then for second iteration --> result = 2 * 2 (i.e. 4)
                // then for third iteration --> result = 4 * 2 (i.e. 8)
                // and we iterate three times becasue powNum = 3
            }

            return result;
        }
    }
}
