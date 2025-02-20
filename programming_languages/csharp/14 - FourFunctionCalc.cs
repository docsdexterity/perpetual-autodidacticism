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
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Calculator CLI");
            Console.WriteLine("-------------------------------------\n");

            Console.Write("Enter a Number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Type any from the following: +, -, *, /");
            Console.Write("Enter Operator: ");
            string op = Console.ReadLine();

            Console.Write("Enter a Number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (op == "+")
            {
                Console.WriteLine(num1 + num2);
            } else if (op == "-")
            {
                Console.WriteLine(num1 - num2);
            } else if (op == "*")
            {
                Console.WriteLine(num1 * num2);
            } else if (op == "/")
            {
                Console.WriteLine(num1 / num2);
            } else
            {
                Console.WriteLine("Invalid Operator or Number");
            }

            Console.ReadLine();
        }      
    }
}
