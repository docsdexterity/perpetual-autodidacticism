using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    internal class Movie
    {
        public string title;
        public string director;
        private string rating; // changed from public to private

        public Movie(string arg_Title, string arg_Director, string arg_Rating)
        {
            title = arg_Title;
            director = arg_Director;

            // To make this more secure, we change the name of rating attribute to Rating
            // This is because if someone creates a Movie object in Program.cs file, like this
            // Movie movie3 = new Movie("yo", "yo", "sd");
            // then, that person will be able to directly set any value for rating attribute.

            Rating = arg_Rating;
            // rating = arg_Rating;
        }

        // Defining properties for getter and setter
        public string Rating 
        {
            get { return rating; } // gets the rating attribute

            // allows to set certain value for rating attribute
            // inside set {}, we define a rule
            // and here, the rule is to check whether the rating is valid or not
            // and then according to that, set the value
            set
            {
                // 'value' represents whatever got passed in
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR")
                {
                    rating = value;
                } else
                {
                    rating = "NR";
                }
            } 
        }
    }
}
