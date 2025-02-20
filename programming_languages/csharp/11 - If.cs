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
