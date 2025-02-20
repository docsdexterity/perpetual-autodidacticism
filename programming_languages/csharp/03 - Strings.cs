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
