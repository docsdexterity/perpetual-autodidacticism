using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class Program
    {   

        // static --> keyword
        // void   --> return type (means nothing or no information is relayed back)
        // Main   --> method's name
        static void Main(string[] args)
        {
            // Console.WriteLine(cube(15));
            int cubedNumber = cube(5);
            Console.WriteLine(cubedNumber);
            Console.ReadLine();          

        }

        // Here return type is int, so an integer is sent back as an information.
        // return type can be any value like a string/double or even an array 
        static int cube(int num)
        {
            int result = num * num * num;
            return result; 
            // return statement can be used to break out of this method/function and return a value to the caller.
        }
    }
}
