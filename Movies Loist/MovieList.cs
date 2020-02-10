using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_11
{
    public class Movie
    {
        private string _title;
        private string _category;

        public string title
        {
            get { return _title; }
            set { _title = value; }

        }
        public string category
        {
            get { return _category; }
            set { _category = value; }

        }

        public Movie(string Title, string Category)
        {
            _title = Title;
            category = Category;
        }

        public static void GetMovies(string userInput, List<Movie> movieList)
        {

            if (userInput.Equals("Horror", StringComparison.OrdinalIgnoreCase) || userInput.Equals("Animated", StringComparison.OrdinalIgnoreCase) || userInput.Equals("Comedy", StringComparison.OrdinalIgnoreCase))
            {
                foreach (var movie in movieList)
                {
                    if (userInput.Equals(movie.category, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine(movie._title);
                    }
                }
            }
            else Console.WriteLine("Category Not Found. Please try again");
        }

        public static string GetUserCategory()
        {
            Console.WriteLine("Hello! Welcome to the Movie Finder app. Select either Horror, Animated, or Comedy movies to list");
            var categoryEntry = Console.ReadLine();
            return categoryEntry;
        }
    }
}
