using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Model
{
    public class Movie
    {
        public int MovieID { get; set; }
        public string Title { get; set; }
        public string MediaFormat { get; set; }
        public string Genre { get; set; }
        public string Owner { get; set; }
        public string Year { get; set; }
        public void Update(IMovie movie)
        {
            Title = movie.Title;
            MediaFormat = movie.MediaFormat;
            Genre = movie.Genre;
            Owner = movie.Owner;
            Year = movie.Year;
        }
    }
}
