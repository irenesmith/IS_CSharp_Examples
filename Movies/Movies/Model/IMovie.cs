using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Model
{
    public interface IMovie
    {
        int MovieID { get; set; }
        string Title { get; set; }
        string MediaFormat { get; set; }
        string Genre { get; set; }
        string Owner { get; set; }
        string Year { get; set; }
    }
}
