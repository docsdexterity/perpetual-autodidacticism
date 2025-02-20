using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    /*
     * When you mark a type or member as "internal," 
     * it can be accessed from any code within the same assembly 
     * but cannot be accessed from code in other assemblies. 
    */

    /*
     * This access modifier provides a level of encapsulation and protection from external code.
     * It allows you to hide implementation details
     * and restrict usage to the components of your application that should have access.
    */

    /*
     * If you have two class files in the same project (which results in the same assembly), 
     * then the "internal" access modifier will work as expected, 
     * and you can access the "internal" types and members between those classes. 
     * This is because they are part of the same assembly, 
     * and "internal" restricts access to within the assembly.
    */

    // Now, question is what does "internal restrics access to within the assembly" means?

    /*
     * So, when we say that "internal" restricts access to within the assembly, 
     * it means that any type or member marked as "internal" can only be accessed 
     * from within the same compiled unit of code, known as an "assembly."
    */

    // In C#, an assembly is typically a single .dll (Dynamic Link Library) or .exe (executable) file.
    internal class Book
    {
        // A series of attributes is supplied here...

        // Different attributes that can be used to represent a book are: title, author, pages.
        // So, what we'll have to do is create separate variables for these attributes.

        /*
         * When you declare something as "public," 
         * it means that it is accessible from any code that has access to the containing type or assembly.
        */

        /*
         * However, it's important to note that using public fields for data storage 
         * is not considered a good practice in modern C# development. 
         * Typically, properties (getters and setters) are used to encapsulate the data 
         * and provide more control over access and validation.
        */

        public string title = "";
        public string author = "";
        public int pages;

        // What we have declared here are also referred to as class attributes.

        // So, now, we can go back to our main program and create an actual book inside of it.
    }
}
