using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Movie_Manager.Classes;
using MySql.Data.MySqlClient;

namespace Movie_Manager.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (OmdbConnectionTest() && DBconnectionTest())
            {
                MainMenu mainMenu = new MainMenu(ApiKeyBox.Text, PasswordBox.Text);
                mainMenu.FormClosed += MainMenu_FormClosed;
                this.Hide();
                mainMenu.Show();
            } 
        }
        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private bool OmdbConnectionTest()
        {
            using (HttpClient client = new HttpClient())
            {
                var url = $"https://www.omdbapi.com/?apikey={ApiKeyBox.Text}&&t=invincible";
                var response = client.GetAsync(url).Result;
                var json = response.Content.ReadAsStringAsync().Result;
                using (JsonDocument doc = JsonDocument.Parse(json))
                {
                    if (doc.RootElement.TryGetProperty("Response", out var responseProp))
                    {
                        if (responseProp.GetString() == "True")
                        {
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Invalid API key. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                return false;
            }
        }
        private bool DBconnectionTest()
        {
            string connectionString = $"server=localhost;user=root;password={PasswordBox.Text}";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    var createDbCmd = new MySqlCommand($"CREATE DATABASE IF NOT EXISTS MovieManager;", conn);
                    createDbCmd.ExecuteNonQuery();
                    var useDbCmd = new MySqlCommand("USE MovieManager;", conn);
                    useDbCmd.ExecuteNonQuery();
                    var createTableCmd = new MySqlCommand(@"
                CREATE TABLE IF NOT EXISTS movies (
                    Id int NOT NULL AUTO_INCREMENT,
                    Title varchar(255) DEFAULT NULL,
                    Year varchar(10) DEFAULT NULL,
                    Rated varchar(50) DEFAULT NULL,
                    Released DATETIME DEFAULT NULL,
                    Runtime varchar(50) DEFAULT NULL,
                    Genre varchar(255) DEFAULT NULL,
                    Director varchar(255) DEFAULT NULL,
                    Writer text,
                    Actors text,
                    Plot text,
                    Language varchar(100) DEFAULT NULL,
                    Country varchar(100) DEFAULT NULL,
                    Awards text,
                    Poster text,
                    Metascore varchar(10) DEFAULT NULL,
                    imdbRating varchar(10) DEFAULT NULL,
                    imdbVotes varchar(50) DEFAULT NULL,
                    imdbID varchar(20) DEFAULT NULL,
                    Type varchar(50) DEFAULT NULL,
                    DVD varchar(50) DEFAULT NULL,
                    BoxOffice varchar(50) DEFAULT NULL,
                    Production varchar(100) DEFAULT NULL,
                    totalSeasons int DEFAULT NULL,
                    Website text,
                    Response varchar(10) DEFAULT NULL,
                    Watched tinyint(1) DEFAULT NULL,
                    PRIMARY KEY (Id)
                ) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
            ", conn);
                    createTableCmd.ExecuteNonQuery();
                    return true;
                }
                catch (MySqlException ex)
                {
                    if (ex.Number == 1045)
                    {
                        MessageBox.Show("Invalid password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    else
                    {
                        MessageBox.Show("Database connection failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
        }
    }
}
