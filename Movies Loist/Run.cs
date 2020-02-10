using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_11
{
    public static class Uses
    {
        public static void Run()
        {
            while (true)
            {

                var movieList = new List<Movie>();

                movieList.Add(new Movie("Conjuring", "Horror"));
                movieList.Add(new Movie("Toy Story", "Animated"));
                movieList.Add(new Movie("Tommy Boy", "Comedy"));
                movieList.Add(new Movie("Saw", "Horror"));
                movieList.Add(new Movie("Finding Nemo", "Animated"));
                movieList.Add(new Movie("My Cousin Vinny", "Comedy"));
                movieList.Add(new Movie("Annabelle", "Horror"));
                movieList.Add(new Movie("Frozen", "Animated"));
                movieList.Add(new Movie("Black Sheep", "Comedy"));
                movieList.Add(new Movie("Pet Semetary", "Horror"));

                var genreInput = Movie.GetUserCategory();

                Movie.GetMovies(genreInput, movieList);

                Console.WriteLine("Would you like to continue looking up movies?");

                var tryAgain = Console.ReadLine().ToLower();

                if (tryAgain == "n")
                {
                    break;
                }
            }
            Console.WriteLine("Goodbye!");
        }
    }
}

