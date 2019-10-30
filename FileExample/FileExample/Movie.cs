using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Bson;

namespace FileExample
{
    class Movie
    {
        public string Title { get; set; }
        public string MediaFormat { get; set; }
        public string Genre { get; set; }
        public string ReleaseYear { get; set; }
    }
}
