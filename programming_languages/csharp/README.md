# C#

<p>[Logging Progress Only]</p>

Reference: [C# Course by Mike Dane](https://www.youtube.com/watch?v=GhQdlIFylQ8)

### Variables

```
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
            string characterName = "John";
            int characterAge = 35;
            
            Console.WriteLine("There once was a man named " + characterName + ".");
            Console.WriteLine("He was " + characterAge + " years old.");
            Console.WriteLine("He really liked the name of George.");
            Console.WriteLine("But didn't like being 70.");

            Console.ReadLine();
        }
    }
}
```

### Data Types

```
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
            string phrase = "Have a good day!";
            char grade = 'A'; // char for single characters
            int age = 30; // int doesn't require quotation marks
            int num = -1;
            // There are three data types for decimals: float, double, decimal (less precise to most precise)
            float a = 3.21;
            double b = 0.2;
            decimal c = 3.444;
            bool enrolStatus = true;
            // bool enrolStatus = false;

            Console.ReadLine();
        }
    }
}
```

### Working with Strings

```
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
            string phrase = "Strike with honor.";
            Console.WriteLine(phrase.Length); // returns length of the string
            Console.WriteLine(phrase.ToUpper()); // turns all letters into uppercase
            Console.WriteLine(phrase.ToLower()); // turns all letters into lowercase
            Console.WriteLine(phrase.Substring(0, 6)); // retrieves a substring, format: .Substring(starting_index, no_of_chars)
            Console.WriteLine(phrase.Contains("Academy")); // to find whether a string contains another string/character
            Console.WriteLine(phrase[0]); // Access the character by its index
            Console.WriteLine(phrase.IndexOf("honor")); // Returns the index of string/character
            Console.WriteLine(phrase.IndexOf('z')); // Returns -1 which signifies absence of string

            Console.ReadLine();
        }
    }
}
```

### Working with Numbers

```
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
```

### Getting User Input

```
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

            Console.Write("Enter your name: "); // .Write() allows the user to write the name in the same line
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            string age = Console.ReadLine();
            Console.WriteLine("Hey " + name + "! What's up?");
            Console.WriteLine("Congrats on turning " + age + " today...");

            Console.ReadLine();

        }
    }
}
```

### Converting String to Int

```
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

            // Converting string value to an integer value
            int num = Convert.ToInt32("45");
            Console.WriteLine(num + 6);

            Console.ReadLine();

        }
    }
}
```

### Calculator for Addition

```
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
```

### Arrays

```
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

            // A variable can only contain a single value
            // To avoid this, we can use another data structure called array which can contain multiple values in a single container

            int[] luckyNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            luckyNumbers[2] = 989;

            Console.WriteLine(luckyNumbers[0]); // In arrays, first element is always indexed at 0
            Console.WriteLine(luckyNumbers[1]);
            Console.WriteLine(luckyNumbers[2]);
            Console.WriteLine(luckyNumbers[3]);
            Console.WriteLine(luckyNumbers[4]);
            Console.WriteLine(luckyNumbers[5]);
            Console.WriteLine(luckyNumbers[6]);
            Console.WriteLine(luckyNumbers[7]);
            Console.WriteLine(luckyNumbers[8]);
            Console.WriteLine(luckyNumbers[9]);
            Console.WriteLine("---------------");

            // Creating a new string array object (empty string array)
            // In 'new string[x]', x is the no of elements/values this array will hold
            string[] friends = new string[5];
            friends[0] = "Jim";
            friends[1] = "Mugen";
            friends[2] = "Shinobi";
            friends[3] = "Jade";
            friends[4] = "Sussy Baka";

            Console.WriteLine(friends[0]);
            Console.WriteLine(friends[1]);
            Console.WriteLine(friends[2]);
            Console.WriteLine(friends[3]);
            Console.WriteLine(friends[4]);

            Console.ReadLine();

        }
    }
}
```

### Methods

```
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
        // void   --> return type
        // Main   --> method's name
        static void Main(string[] args)
        {

            // A method is just a block of code inside a container which can be called to perform a specific task
            // Note: Functions and Methods are closely related but they are not same.
            // This is because a function is a reusable code that isn't tied to any class or object.
            // However, a method can be tied to a class or object and has to be explicitly called in order to work.

            // SayHi();

            // Any value or information given to a method/function is called a parameter.
            // And, a parameter is defined in the parenthesis of that method/function.
            // E.g.

            // SayHi("John");

            // There can be more parameters as well.
            // E.g.

            SayHi("John", 35);
            Console.ReadLine();          

        }

        // Capitalizing the first letter in method's name is a naming convention in C#
        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hello " + name + "! You are " + age + " years old.");
        }
    }
}
```

### Return Statement

```
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
```

### If statements

```
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
            bool isMale = false;
            // if (isMale)
            // {
            //     Console.WriteLine("You are a male.");
            // }
            bool isTall = true;
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("IF using AND Operator");
            Console.WriteLine("-------------------------------------");
            if (isMale && isTall) // '&&' also known as 'AND' checks whether both conditions are true or not
            {
                Console.WriteLine("You are a tall male.");
            }
            else
            {
                Console.WriteLine("You ain't a male or tall either.");
            }

            Console.WriteLine("\n-------------------------------------");
            Console.WriteLine("IF using OR Operator");
            Console.WriteLine("-------------------------------------");
            isMale = false;
            isTall = false;
            if (isMale || isTall)
            {
                Console.WriteLine("You are either male or tall."); 
                // '||' also known as 'OR' checks if either of the condition is true.
            } else
            {
                Console.WriteLine("NULL");
            }

            Console.WriteLine("\n-------------------------------------");
            Console.WriteLine("IF using NOT Operator");
            Console.WriteLine("-------------------------------------");
            isMale = true;
            isTall = false;
            if (isMale && isTall)
            {
                Console.WriteLine("You are a tall male.");
            } else if (isMale && !isTall) 
                // '!' or 'NOT' checks whether the value of isTall variable is false or not
                // '!' is used for negating a boolean variable
                // The code is only executed, if the value of the variable is false
            {
                Console.WriteLine("You are a male but you are not tall.");
            } else if (!isMale && isTall)
            {
                Console.WriteLine("You are tall but you are not male.");
            } else
            {
                Console.WriteLine("You are not either male or tall or both.");
            }

            Console.ReadLine();          
        }      
    }
}
```

### Max Method Using If Statement (for 2 inputs only)

```
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
```

### Max Method Using If Statement (for 3 inputs)

```
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
```

### Four Function Calculator

```
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
```

### Switch Statements

```
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
            // Converting Numbers to Days of the Week
            Console.Write("Enter a Number: ");
            int inpNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(GetDay(inpNum));

            Console.ReadLine();
        }      

        static string GetDay(int dayNum)
        {
            string dayName;

            switch (dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break;
                
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                default:
                    dayName = "Invalid Day Number";
                    break;
            }

            return dayName;
        }
    }
}
```

### Understanding While Loop

```
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
```

### Do-while loop

```
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
            // A do-while loop repeatedly executes a set of instructions at least once (even if it's false,
            // and then continues to execute them as long as a specified condition is true.
            // E.g.

            int index = 6;

            // The code inside the loop is executed first and then the condition is checked.
            do
            {
                Console.WriteLine(index);
                index++;
                // Console.WriteLine(index);
            } while (index <= 5);

            Console.ReadLine();
        }
    }
}
```

### Guessing Game

```
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
            string secretWord = "Dazai";
            string guess = ""; // "" makes the string null
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Guessing Game");
            Console.WriteLine("--------------------------------\n");
            Thread.Sleep(1100);
            Console.WriteLine("You only get 3 turns...\n");
            Thread.Sleep(1100);

            while (guess != secretWord && !outOfGuesses)
            {
                
                if (guessCount < guessLimit)
                {
                    Console.Write("Enter a word: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGuesses = true;
                }
            }
            
            if (outOfGuesses)
            {
                Console.WriteLine("Out of options!");
            } 
            else
            {
                Console.WriteLine("You Won!");
            }
            
            Console.ReadLine();
        }
    }
}
```

### For loops

```
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
```

### Exponents Method

```
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
```

### 2D Arrays

```
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
            // 2D Arrays
            // A 2D Array looks like this:
            // [[1,2,3],
            //  [4,5,6]]
            // So, basically every element inside a 2D array is an array.

            // [,] tells C# that it is a two dimensional array (basically, it's the number of commas)
            // so, for instance, one comma means 2D array
            int[,] arr2D =
            {
                {1,3,7,9},
                {2,4,5,6},
                {0,1,0,1}
            };

            // for declaring specific rows and columns
            int[,] myArr = new int[2, 3];
            // no of rows is 2 i.e. there are 2 elements in 2D array
            // and no of cols is 3 i.e. each element of 2D array will have 3 values

            // Console.WriteLine(arr2D[0,3]); 
            // arr2D[row, col] so basically if row is 0, then it's the first element of 2D array
            // and column value specifies the index of the element that we want to access in the first element of 2D array

            // Print out elements of 2D array
            int numRows = arr2D.GetLength(0);
            int numCols = arr2D.GetLength(1);

            for (int i = 0; i < numRows; i++) // For each value of i, the inner loop (the j loop) will execute.
            {
                for (int j = 0; j < numCols; j++) // iterates over the columns within the current row.
                {
                    // For each value of j,
                    // the code accesses and prints the element at the current row i and column j using arr2D[i, j].
                    Console.Write(arr2D[i, j] + " "); // " " is appended with arr2D[i, j] to add space between elements
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
```

### Comments

```
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
            // A comment is a special line or block of text in our program
            // that gets ignored when we run our program.

            // Comments are meant for humans not machines.
            // A comment can be a little note that elaborates about your code.

            // This is a single-line comment.

            /*
               And
               this
               is 
               a
               multi-line
               comment.
            */

            Console.ReadLine();
        }
    }
}
```

### Exception Handling

```
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
```

### Classes & Objects

- Book.cs

```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    /*
     * When you mark a type or member as "internal," 
     * it can be accessed from any code within the same assembly 
     * but cannot be accessed from code in other assemblies. 
    */

    /*
     * This access modifier provides a level of encapsulation and protection from external code.
     * It allows you to hide implementation details
     * and restrict usage to the components of your application that should have access.
    */

    /*
     * If you have two class files in the same project (which results in the same assembly), 
     * then the "internal" access modifier will work as expected, 
     * and you can access the "internal" types and members between those classes. 
     * This is because they are part of the same assembly, 
     * and "internal" restricts access to within the assembly.
    */

    // Now, question is what does "internal restrics access to within the assembly" means?

    /*
     * So, when we say that "internal" restricts access to within the assembly, 
     * it means that any type or member marked as "internal" can only be accessed 
     * from within the same compiled unit of code, known as an "assembly."
    */

    // In C#, an assembly is typically a single .dll (Dynamic Link Library) or .exe (executable) file.
    internal class Book
    {
        // A series of attributes is supplied here...

        // Different attributes that can be used to represent a book are: title, author, pages.
        // So, what we'll have to do is create separate variables for these attributes.

        /*
         * When you declare something as "public," 
         * it means that it is accessible from any code that has access to the containing type or assembly.
        */

        /*
         * However, it's important to note that using public fields for data storage 
         * is not considered a good practice in modern C# development. 
         * Typically, properties (getters and setters) are used to encapsulate the data 
         * and provide more control over access and validation.
        */

        public string title;
        public string author;
        public int pages;

        // What we have declared here are also referred to as class attributes.

        // So, now, we can go back to our main program and create an actual book inside of it.
    }
}
```

- Program.cs

```
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
            // We have primitive data types like int, string & bool to represent respective data.
            // But these are limited data types which means we can't model everything in our program.
            // And things in the real world cannot be represented using a string or a number or a boolean.
            // For e.g. a phone or a book (there are many examples though)

            // Therefore, we have classes & objects.
            // Now, classes & objects allow us to create our own custom data types.
            // These custom data types then can be used to represent any real life entity.

            // To create a data type, we can create something called 'class'.
            // And a class is a specification for the new data type.

            /*
             * To create a class:
             * - Go to solution explorer
             * - then right click on your project name
             * - then hover over 'Add' and select 'New Item'
             * - from templates, select class and give it a desirable name
             * - (Note: Remember to capitalize the first letter of class name)
             * - finally, click on 'add' button
            */

            // In this case, the class was named as Book.
            // So now, Book is a new custom data type.

            // Classes are like blueprints. It can consist of attributes & methods.
            // So, for e.g., if if we have a class let's say Humans,
            // then the possible attributes can be: name, age, gender, height, weight
            // and possible methods can be: eating, sleeping, respiration, etc.
            // there can be more attributes and methods for this Humans class as well.

            // So, for this program, a seperate Book class has been created. (inside Book.cs)
            // In our main program (Program.cs), we can create an actual book using this Book class
            // and store it inside a variable.
            // In Book.cs, we have defined the Book data type.
            // So, to use this Book data type in our main Program.cs file,
            // We can create an object and an object is basically an instance of the class.

            /*
             * - Firstly, specify the data type (Book)
             * - Declare Variable (book1)
             * - Assignment Operator (=)
             * - Object Creation ( new Book() )
            */

            // The new keyword is used to create a new instance of a class
            // or to allocate memory for an object.
            // It tells the C# runtime to create a new object in memory based on the specified class.

            // In C#, when we create an instance of a class,
            // we typically include parentheses to indicate that we're calling the class's constructor.
            // A constructor is a special method in a class responsible for initializing its objects.

            // Creating Book Object
            Book book1 = new Book(); // Instance of a book
            // So this is like an actual book inside of our program

            // Accessing attributes of Book Object for book1
            book1.title = "No Longer Human";
            book1.author = "Osamu Dazai";
            book1.pages = 490;

            // Creating another Book Object
            Book book2 = new Book();

            // Accessing its attributes
            book2.title = "The Stranger";
            book2.author = "Albert Camus";
            book2.pages = 360;

            // Creating an array of books
            Book[] books = { book1, book2 };

            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine("Book " + (i+1) + " Details"); // (i+1) is used because using just 'i' will return 0
                Console.WriteLine("----------------------");
                Console.WriteLine("Title: " + books[i].title);
                Console.WriteLine("Author: " + books[i].author);
                Console.WriteLine("Pages: " + books[i].pages + "\n");
            }

            Console.ReadLine();
        }
    }
}
```

### Constructors

- Book.cs

```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    internal class Book
    {
        public string title = "";
        public string author = "";
        public int pages;

        // Note: A constructor name is same as the class name.

        public Book() 
        {
            // An empty method like this one allows to do things the old way
            // By old way, I mean defining each class attribute individually.
        }

        public Book(string arg_Title, string arg_Author, int arg_Pages) 
        {
            // Console.WriteLine("Creating Object...");

            // Parametric values gets stored in class attributes respectively.
            title = arg_Title;
            author = arg_Author;
            pages = arg_Pages;
        }

        // When I create a new Book object, the Book() method gets called as well.
    }
}
```

- Program.cs

```
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
            // In C#, when we create an instance of a class,
            // we typically include parentheses to indicate that we're calling the class's constructor.
            // A constructor is a special method in a class responsible for initializing its objects.

            // Instead of entering values for each class attribute,
            // what we can do is define a method for it in our Book class
            // like this:
            /*
             * internal class Book 
             * {
             *      public string title = "";
             *      public string author = "";
             *      public int pages;
             *      
             *      public Book() 
             *      {
             *          Console.WriteLine("Creating Object...");
             *      }
             * }
            */
            // So, when I create a new Book object, the Book() method gets called as well.

            // Book book1 = new Book(); // Output: Creating Object...
            // Book book2 = new Book(); // Output: Creating Object...

            // As there can be many books, entering values for each class attribute is a drag.
            // So, in the constructor method, we can pass these values as parameters.

            // OLD WAY OF DOING THINGS
            /*
             * book1.title = "No Longer Human";
             * book1.author = "Osamu Dazai";
             * book1.pages = 490;
             * 
             * book2.title = "The Stranger";
             * book2.author = "Albert Camus";
             * book2.pages = 360;
            */

            // NEW WAY OF DOING THINGS
            Book book1 = new Book("The Myth of Sisyphus", "Albert Camus", 211);
            Book book2 = new Book("Notes from the Underground", "Fyodor Dostoevsky", 118);

            // Note: You can have more than one constructor.
            // Adding another Book() as well which kinda looks like this:
            /*
             * public Book()
             * {
             *      // An empty method like this one allows to do things the old way
             *      // By old way, I mean defining each class attribute individually.
             * }
            */
            // (Refer Book.cs)

            // So, by doing that, I can create a new Book object like this as well:
            Book book3 = new Book();

            book3.title = "Stories of Osaka life";
            book3.author = "Sakunosuke Oda";
            book3.pages = 192;

            // Creating an array of books
            Book[] books = { book1, book2, book3 };

            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine("Book " + (i+1) + " Details"); // (i
                Console.WriteLine("----------------------");
                Console.WriteLine("Title: " + books[i].title);
                Console.WriteLine("Author: " + books[i].author);
                Console.WriteLine("Pages: " + books[i].pages + "\n");
            }

            Console.ReadLine();
        }
    }
}
```

### Object Methods

- Student.cs
  
```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    internal class Student
    {
        public string name;
        public string major;
        public double gpa;

        public Student(string arg_Name, string arg_Major, double arg_GPA)
        {
            name = arg_Name;
            major = arg_Major;
            gpa = arg_GPA;
        }

        public bool HasHonors()
        {
            if (gpa >= 3.5)
            {
                return true;
            }
            return false;
        }
    }
}
```

- Program.cs

```
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
            // An object method is a method that we can define in our class.
            // So, that the objects of that class can use to either 
            // find out information or modify information about themselves.

            Student student1 = new Student("Joseph", "AIML", 2.6);
            Student student2 = new Student("Nayomi", "Psychology", 3.8);

            // Inside the Student class, we can create a method to find out some information.
            // Let that information be something like finding whether these students are on honor roll or not.
            // An honor roll is a list of students who have earned grades equal to or above a specific average.
            // (let's say the average is 3.5)
            // So, the return values for this method will obviously be either true or false.
            // So, the return type will be boolean or bool simply.

            /*
             * public bool HasHonors() 
             * {
             *      if (gpa >= 3.5) 
             *      {
             *          return true;
             *      }
             *      return false;
             * }
            */

            // So this method is writted once and can be used by n number of objects.

            Console.WriteLine("-------------------");
            Console.WriteLine("Honors List");
            Console.WriteLine("-------------------");
            Console.WriteLine("Student 1: " + student1.HasHonors());    // Output: False
            Console.WriteLine("Student 2: " + student2.HasHonors());    // Output: True

            Console.ReadLine();
        }
    }
}
```

### Getter & Setter

- Movie.cs
  
```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    internal class Movie
    {
        public string title;
        public string director;
        private string rating; // changed from public to private

        public Movie(string arg_Title, string arg_Director, string arg_Rating)
        {
            title = arg_Title;
            director = arg_Director;

            // To make this more secure, we change the name of rating attribute to Rating
            // This is because if someone creates a Movie object in Program.cs file, like this
            // Movie movie3 = new Movie("yo", "yo", "sd");
            // then, that person will be able to directly set any value for rating attribute.

            Rating = arg_Rating;
            // rating = arg_Rating;
        }

        // Defining properties for getter and setter
        public string Rating 
        {
            get { return rating; } // gets the rating attribute

            // allows to set certain value for rating attribute
            // inside set {}, we define a rule
            // and here, the rule is to check whether the rating is valid or not
            // and then according to that, set the value
            set
            {
                // 'value' represents whatever got passed in
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR")
                {
                    rating = value;
                } else
                {
                    rating = "NR";
                }
            } 
        }
    }
}
```

- Program.cs

```
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
            /*
             * Getter & Setter
             * ------------------------------------------------------------------
             * They are basically two types of methods that we can define inside our C# classes,
             * which will essentially control the access that people have to the attributes of those classes.
             * 
             * It makes your classes more secure.
             * 
             * And, it allows you to define like:
             * - what data is valid for specific attributes
             * - & what data is invalid
            */

            Movie movie1 = new Movie("The Avengers", "Joss Whedon", "PG-13");
            Movie movie2 = new Movie("Shrek", "Adam Adamson", "PG");

            // Generally, a movie can have only specific ratings.
            // There maybe more but let's consider these for now:
            // G, PG, PG-13, R, NR

            // So, basically the thing is that, if we consider the rating attribute,
            // it can inferred that this attribute is easily modifiable
            // and its value can be set to anything as well (which is what we don't want in our program)
            // for e.g. movie1.rating = "Dog";

            // We can prevent this from happening,so, that the only possible values for rating are:
            // G, PG, PG-13, R, NR
            // Therefore, we can use getters and setters.

            /*
             * To use getters and setters, we have to modify a couple of things.
             * 
             * - Firstly, we will close off access to the rating property/attribute.
             *   so, for that, we can head over to the Movie.cs file
             *   and there we can change the access modifier from 'public' to 'private'
             *   Note: public means 'it can be accessed by anyone'
             *         private means 'the only code inside Movie class will be able to access the rating'.
             *         
             * - Secondly, we will define getters and setters for this rating attribute.
             *   So, getters and setters allow any outside code to access the rating
             *   and modify and set the values for rating.
            */

            // We can define getters and setters using properties.
            // (properties are like methods)

            // Properties are members of a class that provide a flexible mechanism
            // to read, write, or compute the value of private fields. 

            // They allow to encapsulate private fields and provide controlled access to them.
            // Properties are defined using accessors: get and set.
            // Getter (get): It retrieves the value of the private field.
            // Setter (set): It assigns a value to the private field.

            // Properties enable a class to expose a public way of getting and setting values
            // while hiding the implementation or verification code.

            // Note: always name the property same as the name of attribute but capitalize first letter.

            /*
             * Syntax:
             * 
             * public string Property_Name {
             *      get {}
             *      set {}
             * }
            */

            // Since, rating is private, a statement like this:
            // movie1.rating = "yo";
            // 'Movie1.rating' is inaccessible due to its protetction level
            // And that's what we are doing here
            // Accessing private attribute using getter and setter

            // However, we have defined getters and setters, 
            // there is still one vulnerability left, or in other words,
            // we still need to do one more thing to make this secure
            //
            // let's say, someone creates a new Movie object,
            // then, that person will be able to directly set any value for rating attribute, like this:
            // Movie movie3 = new Movie("yo", "yo", "sd");
            //
            // this is because, in Movie.cs,
            // inside Movie(string arg_Title, string arg_Director, string arg_Rating),
            // rating has been defined like this:
            // rating = arg_Rating;
            // 
            // So, to eliminate this vulnerability
            // we change the name of rating attribute to Rating
            // like this:
            // Rating = arg_Rating;

            // And in our main file, i.e. Program.cs
            // we will use 'Rating' instead of 'rating'.

            // for this, rating value will be NR because the rating value that has been passed is invalid.
            Movie movie3 = new Movie("Oppenheimer", "Christopher Nolan", "Best");

            // for this, rating value will be R because the rating value that has been passed is valid.
            Movie movie4 = new Movie("Peacock", "Michael Lander", "R"); 

            Movie[] movies = { movie1, movie2, movie3, movie4 };

            Console.WriteLine("-------------------------");
            Console.WriteLine("Movies");
            Console.WriteLine("-------------------------\n");

            for (int i = 0; i < movies.Length; i++)
            {
                Console.WriteLine("Movie " + (i + 1));
                Console.WriteLine("Name: " + movies[i].title);
                Console.WriteLine("Director: " + movies[i].director);
                Console.WriteLine("Rating: " + movies[i].Rating + "\n");
            }

            Console.ReadLine();
        }
    }
}
```

### Static Attribute

- Song.cs

```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    internal class Song
    {
        public string title;
        public string artist;
        public int instanceID;
        public static int songCount = 0;

        public Song(string arg_Title, string arg_Artist)
        {
            title = arg_Title;
            artist = arg_Artist;
            instanceID = ++songCount;
        }

        public int getSongCount()
        {
            return instanceID;
        }
    }
}

// In object-oriented programming, static variables, like songCount,
// are shared across all instances of the class.

// When a static variable is incremented,
// its updated value is visible to all instances of the class.

// When songCount is initially 0 and a new Song object is created,
// the ++songCount expression in the constructor pre-increments songCount to 1
// and assigns this value to the instanceID of the current object.
// After this operation, songCount is 1 and the instanceID of the newly created object is also 1.

// If another Song object is created, the same process occurs:
// - songCount is incremented to 2.
// - The new object's instanceID is set to the updated value of songCount, which is 2.

// Difference between Pre-Increment Operation & Post-Increment Operation

/*
 * Pre-Increment Operation:
 * 
 * - songCount is incremented to 1 before its value is assigned to instanceID.
 * - instanceID of the current object becomes 1.
 * - After the operation, songCount is 1.
*/

/*
 * Post-Increment Operation:
 * 
 * - The current value of songCount (0) is used in the expression and 
 *   is assigned to instanceID of the current object.
 * - So, instanceID of the current object becomes 0 (which should've been 1).
 * - Then, songCount is incremented to 1.
*/
```

- Program.cs

```
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
            // static attribute doesn't talk or tell about the objects but rather the class itself.
            // Anything defined as static is accessed through the class name.

            // When a member of a class is declared as static,
            // it means that this member belongs to the class,
            // not to any specific object created from that class.

            // This means there is only one copy of the static member in memory,
            // regardless of how many instances of the class are created.

            Song song1 = new Song("are u ok?", "VOSZA");
            Song song2 = new Song("Forget Me Forget You", "Nakani");
            Song song3 = new Song("NIGHTLIFE", "HXVRMXN");
            Song song4 = new Song("Labyrinth", "Devilish Trio");

            // For e.g. if we want to know how many songs are there in Song class
            // We can create a static variable and set its count to 0
            // and then increment the value each time an object is created.

            // Console.WriteLine("Total Songs: " + Song.songCount);
            Console.WriteLine($"Total Songs: {Song.songCount}");
            
            // Logic behind this has been discussed in Song.cs
            Console.WriteLine($"Song Count for {song2.artist} is {song2.getSongCount()}");
            Console.WriteLine($"Song Count for {song4.artist} is {song4.getSongCount()}");
            Console.WriteLine($"Song Count for {song3.artist} is {song3.getSongCount()}");
            Console.WriteLine($"Song Count for {song1.artist} is {song1.getSongCount()}");

            Console.ReadLine();
        }
    }
}
```

### Static Methods & Classes

- UsefulTools.cs
  
```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    // Using static attribute with classes
    // eliminates the need of creating an object or an instance of the class.

    // So, for e.g., if static wasn't used here, we would still be able to create an object.
    // like UsefulTools myTools = new UsefulTools();
    // Using static attribute prevents that.
    internal static class UsefulTools
    {
        // Static Methods
        // A static method is basically just a method that belongs to the class itself.

        // Usually, when we create methods inside classes, those are used on the objects.

        // But a static method belongs to an actaul class,
        // which means you don't have to create an object
        // in order to use it and access it.

        public static void SayHi(string name)
        {
            Console.WriteLine($"Hello {name}");
        }
    }
}
```

- Program.cs
  
```
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
            // Example of static method in C# can be Math class
            // Math.Sqrt(144);
            // Math is a static class (i.e. object/instance of Math class cannot be created which is also useful).
            // and Sqrt() is a static method which means
            // we don't have to create an object/instance of Math class to use it.

            // Demonstration using UsefulTools class
            UsefulTools.SayHi("Jacob");

            Console.ReadLine();
        }
    }
}
```

### Inheritance

Contains 3 topics: `Inheritance`, `Extending Functionality`, `Method Overriding`

- Chef.cs

```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    internal class Chef
    {
        public void MakeChicken()
        {
            Console.WriteLine("The chef makes chicken.");
        }

        public void MakeSalad()
        {
            Console.WriteLine("The chef makes salad.");
        }

        // virtual indicates that the method can be overridden in sub classes.
        public virtual void MakeSpecialDish()
        {
            Console.WriteLine("The chef makes BBQ Ribs.");
        }
    }
}
```

- ItalianChef.cs

```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    internal class ItalianChef : Chef
    {
        // Let's say,
        // in addition to making chicken, salad and special dish,
        // this Italian Chef can also make pasta

        // This is called extending a functionality.
        public void MakePasta()
        {
            Console.WriteLine("The chef makes pasta.");
        }

        // Method Overriding

        // override indicates that the method is intended to override a method in super class.
        public override void MakeSpecialDish()
        {
            Console.WriteLine("The chef makes lasagna.");
        }
    }
}
```

- Program.cs

```
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
            // Inheritance is basically a technique that we can use in C#,
            // where, we can have one class inherit all of the functionality of another class.

            // So, find/create a superclass 
            // and then all other classes (called subclasses)
            // are going to inherit all the functionality from that superclass.

            // Implementation
            // Inheritance is implemented using the : symbol.
            // e.g. subclass : superclass
            // Refer to ItalianChef.cs

            Chef normalChef = new Chef();
            // chef.MakeChicken();

            ItalianChef italianChef = new ItalianChef();
            // italianChef.MakeSpecialDish();
            // italianChef.MakePasta();

            // You'll notice that only the Italian chef can make the pasta and not the normal chef.
            // This is because, we define the MakePasta() method in subclass only & not in superclass.

            // Now, let's say the Italian Chef also makes a special dish
            // but his special dish is not the same as the normal chef.
            // So, even if we called the MakeSpecialDish() method,
            // it'll return the same value for Italian chef that was inherited from Chef class

            // So, in a situation like this, we can use something called as Method Overriding.

            // Method overriding is a way to change or extend the behavior of a method
            // that is already defined in a parent or superclass.

            // For this, we use two keywords, virtual & override
            // (Refer to Chef.cs & ItalianChef.cs)

            /*
             * virtual keyword
             * 
             * It is used in the base class or super class 
             * to indicate that a method can be overridden in derived sub classes.
            */

            /*
             * override keyword
             * 
             * It is used in a derived class or sub class 
             * to indicate that a method is intended to override a method in the base or super class.
            */

            normalChef.MakeSpecialDish();
            italianChef.MakeSpecialDish();

            Console.ReadLine();
        }
    }
}
```
