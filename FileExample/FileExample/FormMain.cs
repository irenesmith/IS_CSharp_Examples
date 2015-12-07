using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileExample
{
    public partial class FormMain : Form
    {
        string _FileName;
        MovieList _Movies;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // Temporarily hardwired for testing purposes.
            _FileName = @"movies.txt";

            _Movies = new MovieList(_FileName);
        }

        private void LoadGrid()
        {
            if (gridMovies.Rows.Count > 0)
                gridMovies.Rows.Clear();

            gridMovies.DataSource = _Movies.Items;

            // Column Formatting! Because I'm not
            // binding until after the list is loaded
            // the binding settings need to be made
            // here instead of in the designer.
            gridMovies.Columns[0].HeaderText = "Title";
            gridMovies.Columns[0].Width = 380;

            gridMovies.Columns[1].HeaderText = "Format";
            gridMovies.Columns[1].Width = 50;

            gridMovies.Columns[2].HeaderText = "Genre";
            gridMovies.Columns[2].Width = 110;

            gridMovies.Columns[3].HeaderText = "Released";
            gridMovies.Columns[3].Width = 60;
        }

        private void FileOpen_Click(object sender, EventArgs e)
        {
            if ((_FileName == "Untitled") && (_Movies.Items.Count > 0))
            {
                // If the user didn't load the file,
                // then _FileName will still be 'Untitled"
                // so give them a chance to save the file.
            }

            int movieCount = _Movies.ReadAll();

            // Now put the items into the list.
            if (movieCount > 0)
            {
                LoadGrid();
            }
        }

        private void FileSave_Click(object sender, EventArgs e)
        {
            // If the file name is "Untitled" ask the
            // user for a filename and use that instead.


            // Now save the contents of the file.
            _Movies.WriteAll();

            MessageBox.Show("Save completed successfully.");
        }
    }
}
