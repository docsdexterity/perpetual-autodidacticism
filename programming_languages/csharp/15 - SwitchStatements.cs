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
