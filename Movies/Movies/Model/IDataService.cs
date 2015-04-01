using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Model
{
    public interface IDataService
    {
        IList<Movie> GetMovies();
    }

    public class DataServiceStub : IDataService
    {
        public IList<Movie> GetMovies()
        {
            List<Movie> movies = new List<Movie>()
            {
                    new Movie()
                    {
                        MovieID = 0,
                        Title = "101 Dalmations",
                        MediaFormat = "DVD",
                        Owner = "Irene",
                        Genre = "Family",
                        Year = "1959"
                    },
                    new Movie()
                    {
                        MovieID = 1,
                        Title = "Shrek, the Musical",
                        MediaFormat = "DVD",
                        Owner = "Matt",
                        Genre = "Musical",
                        Year = "2010"
                    },
                    new Movie()
                    {
                        MovieID = 2,
                        Title = "The Hobbit",
                        MediaFormat = "DVD",
                        Owner = "Irene",
                        Genre = "Fantasy",
                        Year = "1977"
                    }
            };
            return movies;
        }
    }
}
