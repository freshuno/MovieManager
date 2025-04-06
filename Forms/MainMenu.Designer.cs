namespace Movie_Manager.Forms
{
    partial class MainMenu
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
            MovieTitle = new Label();
            MovieTitleSearchBox = new TextBox();
            SearchButton = new Button();
            SearchPanel = new Panel();
            AddToCollectionButton = new Button();
            DirectorLabel = new Label();
            GenreLabel = new Label();
            RunTimeLabel = new Label();
            ReleaseYearLabel = new Label();
            SearchPanelButton = new Button();
            CollectionPanelButton = new Button();
            button4 = new Button();
            CollectionPanel = new Panel();
            ManageMovieButton = new Button();
            LoadFromFileButton = new Button();
            SaveToFileButton = new Button();
            CollectionMoviesList = new ListBox();
            YourCollectionLabel = new Label();
            SearchPanel.SuspendLayout();
            CollectionPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MovieTitle
            // 
            MovieTitle.Location = new Point(147, 134);
            MovieTitle.Name = "MovieTitle";
            MovieTitle.Size = new Size(289, 15);
            MovieTitle.TabIndex = 0;
            MovieTitle.Text = "Welcome to Movie Manager";
            MovieTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MovieTitleSearchBox
            // 
            MovieTitleSearchBox.Location = new Point(239, 179);
            MovieTitleSearchBox.Name = "MovieTitleSearchBox";
            MovieTitleSearchBox.PlaceholderText = "Movie title";
            MovieTitleSearchBox.Size = new Size(100, 23);
            MovieTitleSearchBox.TabIndex = 1;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(250, 216);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(75, 23);
            SearchButton.TabIndex = 2;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_click;
            // 
            // SearchPanel
            // 
            SearchPanel.Controls.Add(AddToCollectionButton);
            SearchPanel.Controls.Add(DirectorLabel);
            SearchPanel.Controls.Add(GenreLabel);
            SearchPanel.Controls.Add(RunTimeLabel);
            SearchPanel.Controls.Add(ReleaseYearLabel);
            SearchPanel.Controls.Add(SearchButton);
            SearchPanel.Controls.Add(MovieTitleSearchBox);
            SearchPanel.Controls.Add(MovieTitle);
            SearchPanel.Location = new Point(127, 12);
            SearchPanel.Name = "SearchPanel";
            SearchPanel.Size = new Size(661, 426);
            SearchPanel.TabIndex = 3;
            // 
            // AddToCollectionButton
            // 
            AddToCollectionButton.Location = new Point(442, 280);
            AddToCollectionButton.Name = "AddToCollectionButton";
            AddToCollectionButton.Size = new Size(122, 23);
            AddToCollectionButton.TabIndex = 9;
            AddToCollectionButton.Text = "Add to collection";
            AddToCollectionButton.UseVisualStyleBackColor = true;
            AddToCollectionButton.Click += AddToCollectionButton_click;
            // 
            // DirectorLabel
            // 
            DirectorLabel.AutoSize = true;
            DirectorLabel.Location = new Point(478, 242);
            DirectorLabel.Name = "DirectorLabel";
            DirectorLabel.Size = new Size(49, 15);
            DirectorLabel.TabIndex = 8;
            DirectorLabel.Text = "Director";
            // 
            // GenreLabel
            // 
            GenreLabel.AutoSize = true;
            GenreLabel.Location = new Point(478, 216);
            GenreLabel.Name = "GenreLabel";
            GenreLabel.Size = new Size(38, 15);
            GenreLabel.TabIndex = 7;
            GenreLabel.Text = "Genre";
            // 
            // RunTimeLabel
            // 
            RunTimeLabel.AutoSize = true;
            RunTimeLabel.Location = new Point(478, 187);
            RunTimeLabel.Name = "RunTimeLabel";
            RunTimeLabel.Size = new Size(54, 15);
            RunTimeLabel.TabIndex = 6;
            RunTimeLabel.Text = "RunTime";
            // 
            // ReleaseYearLabel
            // 
            ReleaseYearLabel.AutoSize = true;
            ReleaseYearLabel.Location = new Point(478, 162);
            ReleaseYearLabel.Name = "ReleaseYearLabel";
            ReleaseYearLabel.Size = new Size(71, 15);
            ReleaseYearLabel.TabIndex = 3;
            ReleaseYearLabel.Text = "Release Year";
            // 
            // SearchPanelButton
            // 
            SearchPanelButton.Location = new Point(12, 63);
            SearchPanelButton.Name = "SearchPanelButton";
            SearchPanelButton.Size = new Size(75, 23);
            SearchPanelButton.TabIndex = 4;
            SearchPanelButton.Text = "Search";
            SearchPanelButton.UseVisualStyleBackColor = true;
            SearchPanelButton.Click += SearchPanelButton_click;
            // 
            // CollectionPanelButton
            // 
            CollectionPanelButton.Location = new Point(12, 130);
            CollectionPanelButton.Name = "CollectionPanelButton";
            CollectionPanelButton.Size = new Size(75, 47);
            CollectionPanelButton.TabIndex = 5;
            CollectionPanelButton.Text = "My Collection";
            CollectionPanelButton.UseVisualStyleBackColor = true;
            CollectionPanelButton.Click += CollectionPanelButton_click;
            // 
            // button4
            // 
            button4.Location = new Point(12, 220);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 6;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // CollectionPanel
            // 
            CollectionPanel.Controls.Add(ManageMovieButton);
            CollectionPanel.Controls.Add(LoadFromFileButton);
            CollectionPanel.Controls.Add(SaveToFileButton);
            CollectionPanel.Controls.Add(CollectionMoviesList);
            CollectionPanel.Controls.Add(YourCollectionLabel);
            CollectionPanel.Location = new Point(109, 12);
            CollectionPanel.Name = "CollectionPanel";
            CollectionPanel.Size = new Size(661, 426);
            CollectionPanel.TabIndex = 3;
            // 
            // ManageMovieButton
            // 
            ManageMovieButton.Location = new Point(268, 323);
            ManageMovieButton.Name = "ManageMovieButton";
            ManageMovieButton.Size = new Size(122, 23);
            ManageMovieButton.TabIndex = 12;
            ManageMovieButton.Text = "Manage";
            ManageMovieButton.UseVisualStyleBackColor = true;
            ManageMovieButton.Click += ManageMovieButton_Click;
            // 
            // LoadFromFileButton
            // 
            LoadFromFileButton.Location = new Point(379, 379);
            LoadFromFileButton.Name = "LoadFromFileButton";
            LoadFromFileButton.Size = new Size(122, 23);
            LoadFromFileButton.TabIndex = 11;
            LoadFromFileButton.Text = "Load from file";
            LoadFromFileButton.UseVisualStyleBackColor = true;
            LoadFromFileButton.Click += LoadFromFileButton_click;
            // 
            // SaveToFileButton
            // 
            SaveToFileButton.Location = new Point(165, 379);
            SaveToFileButton.Name = "SaveToFileButton";
            SaveToFileButton.Size = new Size(122, 23);
            SaveToFileButton.TabIndex = 10;
            SaveToFileButton.Text = "Save to file";
            SaveToFileButton.UseVisualStyleBackColor = true;
            SaveToFileButton.Click += SaveToFileButton_click;
            // 
            // CollectionMoviesList
            // 
            CollectionMoviesList.FormattingEnabled = true;
            CollectionMoviesList.Location = new Point(57, 88);
            CollectionMoviesList.Name = "CollectionMoviesList";
            CollectionMoviesList.Size = new Size(559, 229);
            CollectionMoviesList.TabIndex = 1;
            CollectionMoviesList.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // YourCollectionLabel
            // 
            YourCollectionLabel.AutoSize = true;
            YourCollectionLabel.Location = new Point(290, 55);
            YourCollectionLabel.Name = "YourCollectionLabel";
            YourCollectionLabel.Size = new Size(81, 15);
            YourCollectionLabel.TabIndex = 0;
            YourCollectionLabel.Text = "My Collection";
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(CollectionPanelButton);
            Controls.Add(SearchPanelButton);
            Controls.Add(CollectionPanel);
            Controls.Add(SearchPanel);
            Name = "MainMenu";
            Text = "MainMenu";
            SearchPanel.ResumeLayout(false);
            SearchPanel.PerformLayout();
            CollectionPanel.ResumeLayout(false);
            CollectionPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox MovieTitleSearchBox;
        private Label MovieTitle;
        private Button SearchButton;
        private Panel SearchPanel;
        private Button SearchPanelButton;
        private Button CollectionPanelButton;
        private Button button4;
        private Panel CollectionPanel;
        private Label YourCollectionLabel;
        private Label DirectorLabel;
        private Label GenreLabel;
        private Label RunTimeLabel;
        private Label ReleaseYearLabel;
        private Button AddToCollectionButton;
        private ListBox CollectionMoviesList;
        private Button SaveToFileButton;
        private Button LoadFromFileButton;
        private Button ManageMovieButton;
    }
}