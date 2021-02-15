using System;
using System.Collections.Generic;

namespace Lab11_02._11
{
    class Program
    {
        static void Main(string[] args)
        {

            var movie = new Movie();
            Console.WriteLine("Welcome to the Movie List Application! There are 10 movies in the list.");

            do
            {
                Console.WriteLine("What category are you interested in? Your category choices are: animated, drama, sci fi, or horror: ");
                var userInput = Console.ReadLine();

                if (userInput == "animated" || userInput == "drama" || userInput == "sci fi" || userInput == "horror")
                {
                    movie.GetListOfMovies(userInput);
                }
                else
                {
                    Console.WriteLine("Sorry! That category is currently unavailable. Please pick a valid category.");
                }

            } while (ContinueInput() == "y");

            Console.WriteLine("Thanks for stopping by! Have a great day!");

        }
        public static string ContinueInput()
        {
            Console.WriteLine("Would you like to continue? (y/n): ");
            string userContinue = Console.ReadLine();
            return userContinue;
        }
    }
}
