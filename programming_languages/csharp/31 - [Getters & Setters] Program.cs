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
            /*
             * Getter & Setter
             * ------------------------------------------------------------------
             * They are basically two types of methods that we can define inside our C# classes,
             * which will essentially control the access that people have to the attributes of those classes.
             * 
             * It makes your classes more secure.
             * 
             * And, it allows you to define like:
             * - what data is valid for specific attributes
             * - & what data is invalid
            */

            Movie movie1 = new Movie("The Avengers", "Joss Whedon", "PG-13");
            Movie movie2 = new Movie("Shrek", "Adam Adamson", "PG");

            // Generally, a movie can have only specific ratings.
            // There maybe more but let's consider these for now:
            // G, PG, PG-13, R, NR

            // So, basically the thing is that, if we consider the rating attribute,
            // it can inferred that this attribute is easily modifiable
            // and its value can be set to anything as well (which is what we don't want in our program)
            // for e.g. movie1.rating = "Dog";

            // We can prevent this from happening,so, that the only possible values for rating are:
            // G, PG, PG-13, R, NR
            // Therefore, we can use getters and setters.

            /*
             * To use getters and setters, we have to modify a couple of things.
             * 
             * - Firstly, we will close off access to the rating property/attribute.
             *   so, for that, we can head over to the Movie.cs file
             *   and there we can change the access modifier from 'public' to 'private'
             *   Note: public means 'it can be accessed by anyone'
             *         private means 'the only code inside Movie class will be able to access the rating'.
             *         
             * - Secondly, we will define getters and setters for this rating attribute.
             *   So, getters and setters allow any outside code to access the rating
             *   and modify and set the values for rating.
            */

            // We can define getters and setters using properties.
            // (properties are like methods)

            // Properties are members of a class that provide a flexible mechanism
            // to read, write, or compute the value of private fields. 

            // They allow to encapsulate private fields and provide controlled access to them.
            // Properties are defined using accessors: get and set.
            // Getter (get): It retrieves the value of the private field.
            // Setter (set): It assigns a value to the private field.

            // Properties enable a class to expose a public way of getting and setting values
            // while hiding the implementation or verification code.

            // Note: always name the property same as the name of attribute but capitalize first letter.

            /*
             * Syntax:
             * 
             * public string Property_Name {
             *      get {}
             *      set {}
             * }
            */

            // Since, rating is private, a statement like this:
            // movie1.rating = "yo";
            // 'Movie1.rating' is inaccessible due to its protetction level
            // And that's what we are doing here
            // Accessing private attribute using getter and setter

            // However, we have defined getters and setters, 
            // there is still one vulnerability left, or in other words,
            // we still need to do one more thing to make this secure
            //
            // let's say, someone creates a new Movie object,
            // then, that person will be able to directly set any value for rating attribute, like this:
            // Movie movie3 = new Movie("yo", "yo", "sd");
            //
            // this is because, in Movie.cs,
            // inside Movie(string arg_Title, string arg_Director, string arg_Rating),
            // rating has been defined like this:
            // rating = arg_Rating;
            // 
            // So, to eliminate this vulnerability
            // we change the name of rating attribute to Rating
            // like this:
            // Rating = arg_Rating;

            // And in our main file, i.e. Program.cs
            // we will use 'Rating' instead of 'rating'.

            // for this, rating value will be NR because the rating value that has been passed is invalid.
            Movie movie3 = new Movie("Oppenheimer", "Christopher Nolan", "Best");

            // for this, rating value will be R because the rating value that has been passed is valid.
            Movie movie4 = new Movie("Peacock", "Michael Lander", "R"); 

            Movie[] movies = { movie1, movie2, movie3, movie4 };

            Console.WriteLine("-------------------------");
            Console.WriteLine("Movies");
            Console.WriteLine("-------------------------\n");

            for (int i = 0; i < movies.Length; i++)
            {
                Console.WriteLine("Movie " + (i + 1));
                Console.WriteLine("Name: " + movies[i].title);
                Console.WriteLine("Director: " + movies[i].director);
                Console.WriteLine("Rating: " + movies[i].Rating + "\n");
            }

            Console.ReadLine();
        }
    }
}
