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
