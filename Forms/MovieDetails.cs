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
    public partial class MovieDetails: Form
    {
        public MovieDetails(Movie Movie)
        {
            InitializeComponent();
            if(Movie.Type == "movie")
            {
                MovieType.Text = "Type: Movie";
            }
            else if (Movie.Type == "series")
            {
                MovieType.Text = "Type: Series";
            }
            else
            {
                MovieType.Text = "Unknown";
            }
            MovieTitle.Text = Movie.Title;
            MovieReleaseYear.Text = "Release year: " + Movie.Year;
            MovieRated.Text = "Rated: " + Movie.Rated;
            MoviePlot.Text = Movie.Plot;
            MovieRuntime.Text = "Run Time: " + Movie.Runtime;
            MovieGenre.Text = "Genre: " + Movie.Genre;
            MovieIMDBRating.Text = "IMDB Rating: " + Movie.imdbRating;
            MoviePoster.ImageLocation = Movie.Poster;
            if (Movie.Watched)
            {
                WatchStatus.Text = "Status: Watched";
            }
            else
            {
                WatchStatus.Text = "Status: Not Watched";
            }
        }
    }
}
