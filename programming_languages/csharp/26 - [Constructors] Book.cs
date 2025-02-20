using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    internal class Book
    {
        public string title = "";
        public string author = "";
        public int pages;

        // Note: A constructor name is same as the class name.

        public Book() 
        {
            // An empty method like this one allows to do things the old way
            // By old way, I mean defining each class attribute individually.
        }

        public Book(string arg_Title, string arg_Author, int arg_Pages) 
        {
            // Console.WriteLine("Creating Object...");

            // Parametric values gets stored in class attributes respectively.
            title = arg_Title;
            author = arg_Author;
            pages = arg_Pages;
        }

        // When I create a new Book object, the Book() method gets called as well.
    }
}
