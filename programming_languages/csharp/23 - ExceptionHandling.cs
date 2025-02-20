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
            // It's probable for a problem or error to occur when your program is running.
            // And when those situations occur, C# throws an exception.
            // An exception tells you that something happened in your code (during execution) that C# couldn't handle.
            // And when an exception gets thrown, a program generally crashes.

            /* 
             * So, for instance, let's consider this program
             * Console.Write("Enter a number: ");
             * int num1 = Convert.ToInt32(Console.ReadLine());
             * Console.Write("Enter another number: ");
             * int num2 = Convert.ToInt32(Console.ReadLine());
             * Console.WriteLine(num1 / num2);
             * Console.ReadLine();
             * So, this code is bound to throw these exceptions:
             * 1. DivideByZeroException - Attempted to divide by zero.
             * 2. FormatException - Input string was not in a correct format.
            */

            // Exception handling is a technique that prevents program from crashing even if any exceptions occur.
            // So a better way to handle these exceptions is to use try & catch blocks
            
            // Any code that we think will break the program goes into the try block
            try 
            {
                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(num1 / num2);
            }

            // catch contains a block of code that should be executed
            // |--> if an exception or error occurs within the corresponding "try" block

            /* 
             * catch
             * {
             *      Console.WriteLine("Error");
             * }
            */

            // To get more information about the error
            // Exception is a class that represents a generic exception in many programming languages.
            // e is a variable name (an identifier) that represents the caught exception.

            /* 
             * catch (Exception e) 
             * {
             *      Console.WriteLine("Error: " + e.Message); // .Message tells what went wrong
             * }
            */

            // Defining multiple catch blocks for specific exceptions is suggested
            // --> if you want different actions for each exception

            catch (DivideByZeroException e)
            {
                Console.WriteLine("Error: " +  e.Message);
            }

            catch (FormatException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

            // Any code inside finally block will be executed no matter what.
            // This can be used when you want to execute a statement after an exception has been thrown.
            // For e.g. this could be allowing the user to input numbers again.
            // But this is not used generally and thus it's optional.

            /* 
             * finally
             * {
             *      ...Some code here...
             * }
            */

            Console.ReadLine();
        }
    }
}
