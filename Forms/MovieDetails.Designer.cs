namespace Movie_Manager.Forms
{
    partial class MovieDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieDetails));
            MoviePoster = new PictureBox();
            MovieTitle = new Label();
            MovieReleaseYear = new Label();
            MovieRated = new Label();
            MovieRuntime = new Label();
            MovieGenre = new Label();
            MoviePlot = new Label();
            MovieIMDBRating = new Label();
            WatchStatus = new Label();
            MovieType = new Label();
            ((System.ComponentModel.ISupportInitialize)MoviePoster).BeginInit();
            SuspendLayout();
            // 
            // MoviePoster
            // 
            MoviePoster.Location = new Point(12, 65);
            MoviePoster.Name = "MoviePoster";
            MoviePoster.Size = new Size(216, 336);
            MoviePoster.SizeMode = PictureBoxSizeMode.StretchImage;
            MoviePoster.TabIndex = 0;
            MoviePoster.TabStop = false;
            // 
            // MovieTitle
            // 
            MovieTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            MovieTitle.Location = new Point(274, 9);
            MovieTitle.Name = "MovieTitle";
            MovieTitle.Size = new Size(353, 62);
            MovieTitle.TabIndex = 1;
            MovieTitle.Text = "label1";
            MovieTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MovieReleaseYear
            // 
            MovieReleaseYear.AutoSize = true;
            MovieReleaseYear.Location = new Point(274, 114);
            MovieReleaseYear.Name = "MovieReleaseYear";
            MovieReleaseYear.Size = new Size(38, 15);
            MovieReleaseYear.TabIndex = 2;
            MovieReleaseYear.Text = "label1";
            // 
            // MovieRated
            // 
            MovieRated.AutoSize = true;
            MovieRated.Location = new Point(274, 152);
            MovieRated.Name = "MovieRated";
            MovieRated.Size = new Size(38, 15);
            MovieRated.TabIndex = 3;
            MovieRated.Text = "label1";
            // 
            // MovieRuntime
            // 
            MovieRuntime.AutoSize = true;
            MovieRuntime.Location = new Point(274, 194);
            MovieRuntime.Name = "MovieRuntime";
            MovieRuntime.Size = new Size(38, 15);
            MovieRuntime.TabIndex = 4;
            MovieRuntime.Text = "label1";
            // 
            // MovieGenre
            // 
            MovieGenre.AutoSize = true;
            MovieGenre.Location = new Point(274, 236);
            MovieGenre.Name = "MovieGenre";
            MovieGenre.Size = new Size(38, 15);
            MovieGenre.TabIndex = 5;
            MovieGenre.Text = "label1";
            // 
            // MoviePlot
            // 
            MoviePlot.Location = new Point(588, 33);
            MoviePlot.Name = "MoviePlot";
            MoviePlot.Size = new Size(145, 274);
            MoviePlot.TabIndex = 6;
            MoviePlot.Text = "label1";
            MoviePlot.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MovieIMDBRating
            // 
            MovieIMDBRating.AutoSize = true;
            MovieIMDBRating.Location = new Point(274, 275);
            MovieIMDBRating.Name = "MovieIMDBRating";
            MovieIMDBRating.Size = new Size(38, 15);
            MovieIMDBRating.TabIndex = 7;
            MovieIMDBRating.Text = "label1";
            // 
            // WatchStatus
            // 
            WatchStatus.AutoSize = true;
            WatchStatus.Location = new Point(274, 363);
            WatchStatus.Name = "WatchStatus";
            WatchStatus.Size = new Size(38, 15);
            WatchStatus.TabIndex = 8;
            WatchStatus.Text = "label1";
            // 
            // MovieType
            // 
            MovieType.AutoSize = true;
            MovieType.Location = new Point(274, 78);
            MovieType.Name = "MovieType";
            MovieType.Size = new Size(38, 15);
            MovieType.TabIndex = 9;
            MovieType.Text = "label1";
            // 
            // MovieDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(767, 492);
            Controls.Add(MovieType);
            Controls.Add(WatchStatus);
            Controls.Add(MovieIMDBRating);
            Controls.Add(MoviePlot);
            Controls.Add(MovieGenre);
            Controls.Add(MovieRuntime);
            Controls.Add(MovieRated);
            Controls.Add(MovieReleaseYear);
            Controls.Add(MovieTitle);
            Controls.Add(MoviePoster);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MovieDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MovieManager - Movie details";
            ((System.ComponentModel.ISupportInitialize)MoviePoster).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox MoviePoster;
        private Label MovieTitle;
        private Label MovieReleaseYear;
        private Label MovieRated;
        private Label MovieRuntime;
        private Label MovieGenre;
        private Label MoviePlot;
        private Label MovieIMDBRating;
        private Label WatchStatus;
        private Label MovieType;
    }
}