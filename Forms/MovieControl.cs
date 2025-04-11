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
using MySql.Data.MySqlClient;


namespace Movie_Manager.Forms
{
    public partial class MovieControl : Form
    {
        string connectionString;
        Movie selectedMovie;
        List<Movie> movies;
        public MovieControl(Movie Movie, List<Movie> Movies, string ConnectionString)
        {
            InitializeComponent();
            connectionString = ConnectionString;
            selectedMovie = Movie;
            movies = Movies;
            label1.Text = Movie.Title;
            MoviePoster.ImageLocation = Movie.Poster;
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
            selectedMovie.Watched = checkBox1.Checked;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE Movies SET Watched = @Watched WHERE imdbID = @imdbID";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Watched", selectedMovie.Watched);
                    cmd.Parameters.AddWithValue("@imdbID", selectedMovie.imdbID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void RemoveMovieButton_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM Movies WHERE imdbID = @imdbID";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@imdbID", selectedMovie.imdbID);
                    cmd.ExecuteNonQuery();
                }
            }

            movies.Remove(selectedMovie);
            Close();
        }
    }
}
