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
        public MovieControl(Movie Movie)
        {
            InitializeComponent();
            selectedMovie = Movie;
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
    }
}
