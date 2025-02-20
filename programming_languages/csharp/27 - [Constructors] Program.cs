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
            // In C#, when we create an instance of a class,
            // we typically include parentheses to indicate that we're calling the class's constructor.
            // A constructor is a special method in a class responsible for initializing its objects.

            // Instead of entering values for each class attribute,
            // what we can do is define a method for it in our Book class
            // like this:
            /*
             * internal class Book 
             * {
             *      public string title = "";
             *      public string author = "";
             *      public int pages;
             *      
             *      public Book() 
             *      {
             *          Console.WriteLine("Creating Object...");
             *      }
             * }
            */
            // So, when I create a new Book object, the Book() method gets called as well.

            // Book book1 = new Book(); // Output: Creating Object...
            // Book book2 = new Book(); // Output: Creating Object...

            // As there can be many books, entering values for each class attribute is a drag.
            // So, in the constructor method, we can pass these values as parameters.

            // OLD WAY OF DOING THINGS
            /*
             * book1.title = "No Longer Human";
             * book1.author = "Osamu Dazai";
             * book1.pages = 490;
             * 
             * book2.title = "The Stranger";
             * book2.author = "Albert Camus";
             * book2.pages = 360;
            */

            // NEW WAY OF DOING THINGS
            Book book1 = new Book("The Myth of Sisyphus", "Albert Camus", 211);
            Book book2 = new Book("Notes from the Underground", "Fyodor Dostoevsky", 118);

            // Note: You can have more than one constructor.
            // Adding another Book() as well which kinda looks like this:
            /*
             * public Book()
             * {
             *      // An empty method like this one allows to do things the old way
             *      // By old way, I mean defining each class attribute individually.
             * }
            */
            // (Refer Book.cs)

            // So, by doing that, I can create a new Book object like this as well:
            Book book3 = new Book();

            book3.title = "Stories of Osaka life";
            book3.author = "Sakunosuke Oda";
            book3.pages = 192;

            // Creating an array of books
            Book[] books = { book1, book2, book3 };

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
