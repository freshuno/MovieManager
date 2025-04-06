using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Movie_Manager.Classes;

namespace Movie_Manager.Forms
{
    public partial class MovieControl : Form
    {
        Movie selectedMovie;
        List<Movie> movies;
        public MovieControl(Movie Movie, int Index, List<Movie> Movies)
        {
            InitializeComponent();
            selectedMovie = Movie;
            movies = Movies;
            label1.Text = Movie.Title;
            if (Movie.Watched)
            {
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                selectedMovie.Watched = true;
            }
            else
            {
                selectedMovie.Watched = false;
            }

        }

        private void RemoveMovieButton_Click(object sender, EventArgs e)
        {
            movies.Remove(selectedMovie);
            Close();
        }
    }
}
