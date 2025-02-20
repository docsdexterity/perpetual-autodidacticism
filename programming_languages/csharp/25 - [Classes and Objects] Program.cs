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
            // We have primitive data types like int, string & bool to represent respective data.
            // But these are limited data types which means we can't model everything in our program.
            // And things in the real world cannot be represented using a string or a number or a boolean.
            // For e.g. a phone or a book (there are many examples though)

            // Therefore, we have classes & objects.
            // Now, classes & objects allow us to create our own custom data types.
            // These custom data types then can be used to represent any real life entity.

            // To create a data type, we can create something called 'class'.
            // And a class is a specification for the new data type.

            /*
             * To create a class:
             * - Go to solution explorer
             * - then right click on your project name
             * - then hover over 'Add' and select 'New Item'
             * - from templates, select class and give it a desirable name
             * - (Note: Remember to capitalize the first letter of class name)
             * - finally, click on 'add' button
            */

            // In this case, the class was named as Book.
            // So now, Book is a new custom data type.

            // Classes are like blueprints. It can consist of attributes & methods.
            // So, for e.g., if if we have a class let's say Humans,
            // then the possible attributes can be: name, age, gender, height, weight
            // and possible methods can be: eating, sleeping, respiration, etc.
            // there can be more attributes and methods for this Humans class as well.

            // So, for this program, a seperate Book class has been created. (inside Book.cs)
            // In our main program (Program.cs), we can create an actual book using this Book class
            // and store it inside a variable.
            // In Book.cs, we have defined the Book data type.
            // So, to use this Book data type in our main Program.cs file,
            // We can create an object and an object is basically an instance of the class.

            /*
             * - Firstly, specify the data type (Book)
             * - Declare Variable (book1)
             * - Assignment Operator (=)
             * - Object Creation ( new Book() )
            */

            // The new keyword is used to create a new instance of a class
            // or to allocate memory for an object.
            // It tells the C# runtime to create a new object in memory based on the specified class.

            // In C#, when we create an instance of a class,
            // we typically include parentheses to indicate that we're calling the class's constructor.
            // A constructor is a special method in a class responsible for initializing its objects.

            // Creating Book Object
            Book book1 = new Book(); // Instance of a book
            // So this is like an actual book inside of our program

            // Accessing attributes of Book Object for book1
            book1.title = "No Longer Human";
            book1.author = "Osamu Dazai";
            book1.pages = 490;

            // Creating another Book Object
            Book book2 = new Book();

            // Accessing its attributes
            book2.title = "The Stranger";
            book2.author = "Albert Camus";
            book2.pages = 360;

            // Creating an array of books
            Book[] books = { book1, book2 };

            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine("Book " + (i+1) + " Details"); // (i
                Console.WriteLine("----------------------");
                Console.WriteLine("Title: " + books[i].title);
                Console.WriteLine("Author: " + books[i].author);
                Console.WriteLine("Pages: " + books[i].pages + "\n");
            }

            Console.ReadLine();
        }
    }
}
