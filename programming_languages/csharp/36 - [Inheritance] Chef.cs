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
