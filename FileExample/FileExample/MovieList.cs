using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Bson;

namespace FileExample
{
    class MovieList
    {
        private string _FileName;
        public List<Movie> Items { get; set; }

        private const int _TitleColumn = 0;
        private const int _FormatColumn = 1;
        private const int _GenreColumn = 2;
        private const int _YearColumn = 3;

        public MovieList()
        {
            _FileName = "Untitled";
            Items = new List<Movie>();
        }

        public MovieList(string FileName)
        {
            _FileName = FileName;
            Items = new List<Movie>();
        }

        public void WriteAll()
        {
            // Write the contents of the list to the file.
                using (StreamWriter writer = new StreamWriter(_FileName, false))
                {
                    foreach (Movie m in Items)
                    {
                        StringBuilder stringOut = new StringBuilder(m.Title);
                        stringOut.Append("\t" + m.MediaFormat);
                        stringOut.Append("\t" + m.Genre);
                        stringOut.Append("\t" + m.ReleaseYear);
                        writer.WriteLine(stringOut);
                    }
                    
                }
        }

        public int ReadAll()
        {
            // Read the contents of the list from the file.
            // Since we're using the file, we don't have to
            // worry about disposing of it when we're done.
            using (StreamReader reader = File.OpenText(_FileName))
            {
                string lineIn;
                string[] columns;
                while (!reader.EndOfStream)
                {
                    // Get the line and split it
                    // into separate columns.
                    lineIn = reader.ReadLine();
                    columns = lineIn.Split('\t');

                    // Assign the column values
                    // to the properties of a
                    // movie object.
                    Movie m = new Movie
                    {
                        Title = columns[_TitleColumn],
                        MediaFormat = columns[_FormatColumn],
                        Genre = columns[_GenreColumn],
                        ReleaseYear = columns[_YearColumn]
                    };
                    // Add the movie to list.
                    Items.Add(m);
                }

            }

            return Items.Count;
        }
    }
}
