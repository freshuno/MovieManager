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
using System.Text.Json;
using MySql.Data.MySqlClient;


namespace Movie_Manager.Forms
{
    public partial class MainMenu : Form
    {
        readonly string connectionString;
        readonly string apiKey;
        public List<Movie> myMovies = [];
        List<Movie> moviesToDisplay = [];
        Movie currentMovie;
        int currentPage = 1;
        int pageSize = 15;
        int totalPages = 1;
        public MainMenu(string ApiKey, string Password)
        {
            apiKey = ApiKey;
            connectionString = $"server=localhost;user=root;password={Password};database=MovieManager;";
            InitializeComponent();
            LoadMoviesFromDatabase();
            SearchPanel.Show();
            CollectionPanel.Hide();
        }
        private void SearchButton_click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(MovieTitleSearchBox.Text))
            {
                MessageBox.Show("Please enter a movie title");
                return;
            }
            string searchedTitle = MovieTitleSearchBox.Text;
            string url = $"https://www.omdbapi.com/?apikey={apiKey}&&t={searchedTitle}";
            using (HttpClient client = new HttpClient())
            {
                var response = client.GetAsync(url).Result;
                var json = response.Content.ReadAsStringAsync().Result;
                Movie movie = JsonSerializer.Deserialize<Movie>(json);
                currentMovie = movie;
                MovieTitle.Text = movie.Title;
                if (movie.Title == null)
                {
                    AddToCollectionButton.Visible = false;
                    MovieTitle.Text = MovieTitleSearchBox.Text + " not found";
                    ReleaseYearLabel.Text = "";
                    RunTimeLabel.Text = "";
                    GenreLabel.Text = "";
                    DirectorLabel.Text = "";
                    PlotLabel.Text = "";
                    MoviePoster.Image = null;
                }
                else
                {
                    AddToCollectionButton.Visible = true;
                }
                if (movie.Poster != "N/A" && movie.Poster != null)
                {
                    MoviePoster.Load(movie.Poster);
                }
                else
                {
                    MoviePoster.Image = null;
                }
                if (movie.Type == "movie")
                {
                    ReleaseYearLabel.Text = "Release year: " + movie.Year;
                    RunTimeLabel.Text = "Run time: " + movie.Runtime;
                    GenreLabel.Text = "Genre " + movie.Genre;
                    DirectorLabel.Text = "Director: " + movie.Director;
                    PlotLabel.Text = "Plot: " + movie.Plot;
                }
                if (movie.Type == "series")
                {
                    ReleaseYearLabel.Text = "Running years: " + movie.Year;
                    RunTimeLabel.Text = "";
                    GenreLabel.Text = "Genre " + movie.Genre;
                    DirectorLabel.Text = "";
                    PlotLabel.Text = "Plot: " + movie.Plot;
                }
            }
        }

        private void SearchPanelButton_click(object sender, EventArgs e)
        {
            SearchPanel.Show();
            CollectionPanel.Hide();
        }

        private void CollectionPanelButton_click(object sender, EventArgs e)
        {
            CollectionPanel.Show();
            SearchPanel.Hide();
        }

        private void AddToCollectionButton_click(object sender, EventArgs e)
        {
            if (myMovies.Any(m => m.Title == currentMovie.Title && m.Year == currentMovie.Year))
            {
                MessageBox.Show("Movie is already in your collection");
                return;
            }
            else
            {
                if(currentMovie.imdbRating == "N/A" || currentMovie.imdbRating == null)
                {
                    currentMovie.imdbRating = "0";
                }
                myMovies.Add(currentMovie);
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"INSERT INTO Movies 
    (Title, Year, Rated, Released, Runtime, Genre, Director, Writer, Actors, Plot, Language, Country, Awards, Poster, Metascore, imdbRating, imdbVotes, imdbID, Type, DVD, BoxOffice, Production, Website, Response, Watched)
    VALUES
    (@Title, @Year, @Rated, @Released, @Runtime, @Genre, @Director, @Writer, @Actors, @Plot, @Language, @Country, @Awards, @Poster, @Metascore, @imdbRating, @imdbVotes, @imdbID, @Type, @DVD, @BoxOffice, @Production, @Website, @Response, @Watched)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Title", currentMovie.Title);
                        cmd.Parameters.AddWithValue("@Year", currentMovie.Year);
                        cmd.Parameters.AddWithValue("@Rated", currentMovie.Rated);
                        cmd.Parameters.AddWithValue("@Released", currentMovie.Released);
                        cmd.Parameters.AddWithValue("@Runtime", currentMovie.Runtime);
                        cmd.Parameters.AddWithValue("@Genre", currentMovie.Genre);
                        cmd.Parameters.AddWithValue("@Director", currentMovie.Director);
                        cmd.Parameters.AddWithValue("@Writer", currentMovie.Writer);
                        cmd.Parameters.AddWithValue("@Actors", currentMovie.Actors);
                        cmd.Parameters.AddWithValue("@Plot", currentMovie.Plot);
                        cmd.Parameters.AddWithValue("@Language", currentMovie.Language);
                        cmd.Parameters.AddWithValue("@Country", currentMovie.Country);
                        cmd.Parameters.AddWithValue("@Awards", currentMovie.Awards);
                        cmd.Parameters.AddWithValue("@Poster", currentMovie.Poster);
                        cmd.Parameters.AddWithValue("@Metascore", currentMovie.Metascore);
                        cmd.Parameters.AddWithValue("@imdbRating", currentMovie.imdbRating);
                        cmd.Parameters.AddWithValue("@imdbVotes", currentMovie.imdbVotes);
                        cmd.Parameters.AddWithValue("@imdbID", currentMovie.imdbID);
                        cmd.Parameters.AddWithValue("@Type", currentMovie.Type);
                        cmd.Parameters.AddWithValue("@DVD", currentMovie.DVD);
                        cmd.Parameters.AddWithValue("@BoxOffice", currentMovie.BoxOffice);
                        cmd.Parameters.AddWithValue("@Production", currentMovie.Production);
                        cmd.Parameters.AddWithValue("@Website", currentMovie.Website);
                        cmd.Parameters.AddWithValue("@Response", currentMovie.Response);
                        cmd.Parameters.AddWithValue("@Watched", currentMovie.Watched);

                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Film dodany do listy");
                MovieListRefresh();
            }
        }
        private void ManageMovieButton_Click(object sender, EventArgs e)
        {
            try
            {
                MovieControl movieControl = new MovieControl(moviesToDisplay[CollectionMoviesList.SelectedIndex + pageSize * (currentPage - 1)], myMovies);
                movieControl.ShowDialog();
                MovieListRefresh();
            }
            catch (Exception)
            {
                MessageBox.Show("Choose a movie from the list");
                return;
            }
        }
        private void ShowDetailsButton_Click(object sender, EventArgs e)
        {
            try
            {
                MovieDetails movieDetails = new MovieDetails(moviesToDisplay[CollectionMoviesList.SelectedIndex + pageSize * (currentPage - 1)]);
                movieDetails.ShowDialog();
                MovieListRefresh();
            }
            catch (Exception)
            {
                MessageBox.Show("Choose a movie from the list");
                return;
            }
        }
        private void LoadMoviesFromDatabase()
        {
            myMovies.Clear();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Movies";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Movie movie = new Movie
                            {
                                Title = reader["Title"].ToString(),
                                Year = reader["Year"].ToString(),
                                Rated = reader["Rated"].ToString(),
                                Released = reader["Released"].ToString(),
                                Runtime = reader["Runtime"].ToString(),
                                Genre = reader["Genre"].ToString(),
                                Director = reader["Director"].ToString(),
                                Writer = reader["Writer"].ToString(),
                                Actors = reader["Actors"].ToString(),
                                Plot = reader["Plot"].ToString(),
                                Language = reader["Language"].ToString(),
                                Country = reader["Country"].ToString(),
                                Awards = reader["Awards"].ToString(),
                                Poster = reader["Poster"].ToString(),
                                Metascore = reader["Metascore"].ToString(),
                                imdbRating = reader["imdbRating"].ToString(),
                                imdbVotes = reader["imdbVotes"].ToString(),
                                imdbID = reader["imdbID"].ToString(),
                                Type = reader["Type"].ToString(),
                                DVD = reader["DVD"].ToString(),
                                BoxOffice = reader["BoxOffice"].ToString(),
                                Production = reader["Production"].ToString(),
                                Website = reader["Website"].ToString(),
                                Response = reader["Response"].ToString(),
                                Watched = Convert.ToBoolean(reader["Watched"])
                            };
                            myMovies.Add(movie);
                        }
                    }
                }
            }
            MovieListRefresh();
        }

        private void MovieListRefresh()
        {
            CollectionMoviesList.Items.Clear();
            moviesToDisplay = myMovies;

            if (UnwatchedOnlyCheckBox.Checked)
            {
                moviesToDisplay = moviesToDisplay.Where(m => !m.Watched).ToList();
            }

            int totalItems = moviesToDisplay.Count();
            totalPages = (int)Math.Ceiling(totalItems / (double)pageSize);
            if (currentPage > totalPages)
            {
                currentPage = totalPages;
            }
            var paginatedMovies = moviesToDisplay
                .Skip((currentPage - 1) * pageSize)
                .Take(pageSize);
            foreach (var movie in paginatedMovies)
            {
                CollectionMoviesList.Items.Add(movie.Title + " " + movie.Year);
            }

            PageLabel.Text = $"Page {currentPage} of {totalPages}";
            PreviousPageButton.Enabled = currentPage > 1;
            NextPageButton.Enabled = currentPage < totalPages;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (SortOptions.SelectedItem.ToString())
            {
                case "Title":
                    myMovies = myMovies.OrderBy(m => m.Title).ToList();
                    break;
                case "Year":
                    myMovies = myMovies.OrderBy(m => m.Year).ToList();
                    myMovies.Reverse();
                    break;
                case "Run Time":
                    myMovies = myMovies.OrderBy(m => m.Runtime).ToList();
                    break;
                case "Rating":
                    myMovies = myMovies.OrderBy(m => m.imdbRating).ToList();
                    myMovies.Reverse();
                    break;
            }

            MovieListRefresh();
        }

        private void UnwatchedOnlyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MovieListRefresh();
        }

        private void PreviousPageButton_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                MovieListRefresh();
            }
        }

        private void NextPageButton_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                MovieListRefresh();
            }
        }

        private void NameSearchButton_Click(object sender, EventArgs e)
        {
            var searchedMovie = myMovies.FirstOrDefault(m =>m.Title != null && m.Title.Equals(NameSearchBox.Text, StringComparison.OrdinalIgnoreCase));
            if(searchedMovie == null)
            {
                MessageBox.Show("Movie not found in your collection");
            }
            else
            {
                MovieDetails movieDetals = new MovieDetails(searchedMovie);
                movieDetals.ShowDialog();
            }
        }
    }
}
