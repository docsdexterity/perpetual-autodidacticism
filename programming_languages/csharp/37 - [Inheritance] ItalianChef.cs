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
