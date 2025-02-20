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
