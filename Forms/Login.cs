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
            if (omdbConnectionTest() && dbConnectionTest())
            {
                MainMenu mainMenu = new MainMenu(ApiKeyBox.Text, PasswordBox.Text);
                this.Hide();
                mainMenu.Show();
            }
        }
        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private bool omdbConnectionTest()
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
        private bool dbConnectionTest()
        {
            string connectionString = $"server=localhost;user=root;password={PasswordBox.Text};database=MovieManager;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
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
