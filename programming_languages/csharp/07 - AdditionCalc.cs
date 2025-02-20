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

            Console.Write("Enter two numbers: \n");
            // int is not a good choice because if either of the entered number has a decimal value the program will stall
            // int num1 = Convert.ToInt32(Console.ReadLine());
            // int num2 = Convert.ToInt32(Console.ReadLine());
            // int sum = num1 + num2;

            // instead, we can convert the string to double data type
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());
            double sum = num1 + num2;
            Console.WriteLine("Sum is " + sum);

            Console.ReadLine();

        }
    }
}
