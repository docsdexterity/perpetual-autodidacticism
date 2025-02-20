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
            Console.WriteLine(GetMax(20, 20, 20));
            Console.ReadLine();          
        }      

        static int GetMax(int num1, int num2, int num3)
        {
            int result;

            if (num1 > num2 && num1 >num3)
            {
                result = num1;
                Console.WriteLine("Num 1 is greater than Num 2 and Num 3.");
            }   else if (num1 == num2  && num1 == num3)
            {
                result = num1;
                Console.WriteLine("All numbers are equal.");
            }   else if (num2 > num1 && num2 > num3)
            {
                result = num2;
                Console.WriteLine("Num 2 is greater than Num 1 and Num 3.");
            }   else
            {
                result = num3;
                Console.WriteLine("Num 3 is greate than Num 1 and Num 3");
            }

            return result;
        }
    }
}
