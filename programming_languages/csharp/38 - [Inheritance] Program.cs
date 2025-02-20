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
