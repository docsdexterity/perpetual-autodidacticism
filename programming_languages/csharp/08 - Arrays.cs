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
