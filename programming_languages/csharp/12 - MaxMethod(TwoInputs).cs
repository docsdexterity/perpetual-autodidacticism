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
            Console.WriteLine(GetMax(4, 5));
            Console.ReadLine();          
        }      

        static int GetMax(int num1, int num2)
        {
            int result;

            if (num1 > num2)
            {
                result = num1;
                Console.WriteLine("Num 1 is greater than Num 2.");
            }   else if (num1 == num2)
            {
                result = num1; // If not specified, "use of unassigned local variable" error is thrown.
                Console.WriteLine("Both Numbers are equal.");
            }   else
            {
                result = num2;
                Console.WriteLine("Num 2 is greate than Num 1");
            }

            return result;
        }
    }
}
