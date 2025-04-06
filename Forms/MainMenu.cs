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

namespace Movie_Manager.Forms
{
    public partial class MainMenu : Form
    {
        
        public List<Movie> myMovies = [];
        Movie currentMovie;
        public MainMenu()
        {
            InitializeComponent();
            SearchPanel.Show();
            CollectionPanel.Hide();
        }

        private void SearchButton_click(object sender, EventArgs e)
        {
            string searchedTitle = MovieTitleSearchBox.Text;
            string url = $"https://www.omdbapi.com/?apikey={apiKey}&&t={searchedTitle}";
            using (HttpClient client = new HttpClient())
            {
                var response = client.GetAsync(url).Result;
                var json = response.Content.ReadAsStringAsync().Result;
                Movie movie = JsonSerializer.Deserialize<Movie>(json);
                currentMovie = movie;
                MovieTitle.Text = movie.Title;
                ReleaseYearLabel.Text = "Release year: " + movie.Year;
                RunTimeLabel.Text = "Run time: " + movie.Runtime;
                GenreLabel.Text = "Genre " + movie.Genre;
                DirectorLabel.Text = "Director: " + movie.Director;

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
            MovieListRefresh();
        }

        private void AddToCollectionButton_click(object sender, EventArgs e)
        {
            if (myMovies.Any(m => m.Title == currentMovie.Title && m.Year == currentMovie.Year))
            {
                MessageBox.Show("Film już dodany do listy");
                return;
            }
            else
            {
                myMovies.Add(currentMovie);
                MessageBox.Show("Film dodany do listy");
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MovieControl movieControl = new MovieControl(myMovies[CollectionMoviesList.SelectedIndex]);
            movieControl.ShowDialog();
        }

        private void SaveToFileButton_click(object sender, EventArgs e)
        {
            string filePath = "data.json";
            string jsonString = JsonSerializer.Serialize(myMovies, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, jsonString);

        }

        private void LoadFromFileButton_click(object sender, EventArgs e)
        {
            string filePath = "data.json";
            string jsonString = File.ReadAllText(filePath);
            myMovies = JsonSerializer.Deserialize<List<Movie>>(jsonString);
            MovieListRefresh();
        }
        private void MovieListRefresh()
        {
            CollectionMoviesList.Items.Clear();
            foreach (Movie movie in myMovies)
            {
                CollectionMoviesList.Items.Add(movie.Title);
            }
        }
    }
}
