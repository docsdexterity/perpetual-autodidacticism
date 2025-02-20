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
            // a for loop allows us to keep track of the iterating variable
            // for (variable initialization; loop condition; statement to execute after each iteration;) {}

            int[] arr = { 4, 8, 12, 16, 20, 24, 28, 32 };
            // Console.WriteLine(arr.Length);

            for (int i = 0; i < arr.Length; i++) // here <= cannot be used as it throws an unhandled exception
                // this is because we are accessing an index that doesn't exist
                // like in this case, the length of array is 8 and since i starts from 0, the last index will be 7
                // but when using <=, the loop runs one more time for 8th index (which doesn't exist)
                // and thus an unhandled exception is thrown.
            {
                // as i = 0, (i+1) is intended for showing elements sequentially in human readable format
                Console.WriteLine("Element " + (i+1) + ": " + arr[i]);
            }
            
            Console.ReadLine();
        }
    }
}
