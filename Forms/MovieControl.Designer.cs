namespace Movie_Manager.Forms
{
    partial class MovieControl
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
            label1 = new Label();
            checkBox1 = new CheckBox();
            RemoveMovieButton = new Button();
            MoviePoster = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)MoviePoster).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(87, 55);
            label1.Name = "label1";
            label1.Size = new Size(246, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(324, 112);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(73, 19);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Watched";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // RemoveMovieButton
            // 
            RemoveMovieButton.Location = new Point(158, 170);
            RemoveMovieButton.Name = "RemoveMovieButton";
            RemoveMovieButton.Size = new Size(104, 40);
            RemoveMovieButton.TabIndex = 2;
            RemoveMovieButton.Text = "Remove from collection";
            RemoveMovieButton.UseVisualStyleBackColor = true;
            RemoveMovieButton.Click += RemoveMovieButton_Click;
            // 
            // MoviePoster
            // 
            MoviePoster.Location = new Point(22, 26);
            MoviePoster.Name = "MoviePoster";
            MoviePoster.Size = new Size(108, 174);
            MoviePoster.SizeMode = PictureBoxSizeMode.StretchImage;
            MoviePoster.TabIndex = 3;
            MoviePoster.TabStop = false;
            // 
            // MovieControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 241);
            Controls.Add(MoviePoster);
            Controls.Add(RemoveMovieButton);
            Controls.Add(checkBox1);
            Controls.Add(label1);
            Name = "MovieControl";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MovieControl";
            ((System.ComponentModel.ISupportInitialize)MoviePoster).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CheckBox checkBox1;
        private Button RemoveMovieButton;
        private PictureBox MoviePoster;
    }
}