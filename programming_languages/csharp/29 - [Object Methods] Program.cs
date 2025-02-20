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
