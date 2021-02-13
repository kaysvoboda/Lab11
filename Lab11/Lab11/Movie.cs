using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Lab11_02._11
{
    public class Movie
    {
        private string _title { get; set; }
        private string _category { get; set; }

        public Movie()
        {

        }

        public Movie(string title, string category)
        {
            _title = title;
            _category = category;
        }

        public void GetListOfMovies(string userinput)
        {
            var list = InitializeList();
            list.Sort((m1, m2) => m1._title.CompareTo(m2._title));
            foreach (var movie in list)
            {
                if ((movie._category == userinput) == true)
                {
                    Console.WriteLine(movie._title);
                }
            }
        }

        private List<Movie> InitializeList()
        {
            var list = new List<Movie>
            {
                new Movie("Spirited Away", "animated"),
                new Movie("Frozen", "animated"),
                new Movie("Friday the 13th", "horror"),
                new Movie("Django: Unchained", "drama"),
                new Movie("Saw", "horror"),
                new Movie("Star Wars", "sci fi"),
                new Movie("Star Trek", "sci fi"),
                new Movie("Fight Club", "drama"),
                new Movie("Jurrasic Park", "sci fi"),
                new Movie("Se7en", "drama"),
                new Movie("Annabelle", "horror")
            };

            return list;
        }

    }
}
