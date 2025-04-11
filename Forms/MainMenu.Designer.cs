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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            MovieTitle = new Label();
            MovieTitleSearchBox = new TextBox();
            SearchButton = new Button();
            SearchPanel = new Panel();
            TotalSeasonsLabel = new Label();
            MoviePoster = new PictureBox();
            PlotLabel = new Label();
            AddToCollectionButton = new Button();
            DirectorLabel = new Label();
            GenreLabel = new Label();
            RunTimeLabel = new Label();
            ReleaseYearLabel = new Label();
            SearchPanelButton = new Button();
            CollectionPanelButton = new Button();
            CollectionPanel = new Panel();
            SortLabel = new Label();
            NameSearchButton = new Button();
            NameSearchBox = new TextBox();
            ShowDetailsButton = new Button();
            PageLabel = new Label();
            NextPageButton = new Button();
            PreviousPageButton = new Button();
            UnwatchedOnlyCheckBox = new CheckBox();
            SortOptions = new ComboBox();
            ManageMovieButton = new Button();
            CollectionMoviesList = new ListBox();
            YourCollectionLabel = new Label();
            ExitButton = new Button();
            SearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MoviePoster).BeginInit();
            CollectionPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MovieTitle
            // 
            MovieTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            MovieTitle.Location = new Point(191, 26);
            MovieTitle.Name = "MovieTitle";
            MovieTitle.Size = new Size(228, 128);
            MovieTitle.TabIndex = 0;
            MovieTitle.Text = "Welcome to Movie Manager";
            MovieTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MovieTitleSearchBox
            // 
            MovieTitleSearchBox.Location = new Point(191, 162);
            MovieTitleSearchBox.Name = "MovieTitleSearchBox";
            MovieTitleSearchBox.PlaceholderText = "Movie title";
            MovieTitleSearchBox.Size = new Size(232, 23);
            MovieTitleSearchBox.TabIndex = 1;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(262, 191);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(75, 23);
            SearchButton.TabIndex = 2;
            SearchButton.Tag = false;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_click;
            // 
            // SearchPanel
            // 
            SearchPanel.Controls.Add(TotalSeasonsLabel);
            SearchPanel.Controls.Add(MoviePoster);
            SearchPanel.Controls.Add(PlotLabel);
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
            // TotalSeasonsLabel
            // 
            TotalSeasonsLabel.AutoSize = true;
            TotalSeasonsLabel.Location = new Point(-1, 302);
            TotalSeasonsLabel.Name = "TotalSeasonsLabel";
            TotalSeasonsLabel.Size = new Size(0, 15);
            TotalSeasonsLabel.TabIndex = 12;
            // 
            // MoviePoster
            // 
            MoviePoster.Location = new Point(-1, 26);
            MoviePoster.Name = "MoviePoster";
            MoviePoster.Size = new Size(186, 273);
            MoviePoster.SizeMode = PictureBoxSizeMode.StretchImage;
            MoviePoster.TabIndex = 11;
            MoviePoster.TabStop = false;
            // 
            // PlotLabel
            // 
            PlotLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PlotLabel.Location = new Point(429, 13);
            PlotLabel.Name = "PlotLabel";
            PlotLabel.Padding = new Padding(20);
            PlotLabel.RightToLeft = RightToLeft.No;
            PlotLabel.Size = new Size(211, 399);
            PlotLabel.TabIndex = 10;
            PlotLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AddToCollectionButton
            // 
            AddToCollectionButton.Location = new Point(241, 229);
            AddToCollectionButton.Name = "AddToCollectionButton";
            AddToCollectionButton.Size = new Size(122, 23);
            AddToCollectionButton.TabIndex = 9;
            AddToCollectionButton.Text = "Add to collection";
            AddToCollectionButton.UseVisualStyleBackColor = true;
            AddToCollectionButton.Visible = false;
            AddToCollectionButton.Click += AddToCollectionButton_click;
            // 
            // DirectorLabel
            // 
            DirectorLabel.AutoSize = true;
            DirectorLabel.Location = new Point(-1, 359);
            DirectorLabel.Name = "DirectorLabel";
            DirectorLabel.Size = new Size(0, 15);
            DirectorLabel.TabIndex = 8;
            // 
            // GenreLabel
            // 
            GenreLabel.AutoSize = true;
            GenreLabel.Location = new Point(-1, 331);
            GenreLabel.Name = "GenreLabel";
            GenreLabel.Size = new Size(0, 15);
            GenreLabel.TabIndex = 7;
            // 
            // RunTimeLabel
            // 
            RunTimeLabel.AutoSize = true;
            RunTimeLabel.Location = new Point(-1, 302);
            RunTimeLabel.Name = "RunTimeLabel";
            RunTimeLabel.Size = new Size(0, 15);
            RunTimeLabel.TabIndex = 6;
            // 
            // ReleaseYearLabel
            // 
            ReleaseYearLabel.AutoSize = true;
            ReleaseYearLabel.Location = new Point(-1, 271);
            ReleaseYearLabel.Name = "ReleaseYearLabel";
            ReleaseYearLabel.Size = new Size(0, 15);
            ReleaseYearLabel.TabIndex = 7;
            // 
            // SearchPanelButton
            // 
            SearchPanelButton.Location = new Point(12, 128);
            SearchPanelButton.Name = "SearchPanelButton";
            SearchPanelButton.Size = new Size(75, 23);
            SearchPanelButton.TabIndex = 4;
            SearchPanelButton.Text = "Search";
            SearchPanelButton.UseVisualStyleBackColor = true;
            SearchPanelButton.Click += SearchPanelButton_click;
            // 
            // CollectionPanelButton
            // 
            CollectionPanelButton.Location = new Point(12, 203);
            CollectionPanelButton.Name = "CollectionPanelButton";
            CollectionPanelButton.Size = new Size(75, 47);
            CollectionPanelButton.TabIndex = 5;
            CollectionPanelButton.Text = "My Collection";
            CollectionPanelButton.UseVisualStyleBackColor = true;
            CollectionPanelButton.Click += CollectionPanelButton_click;
            // 
            // CollectionPanel
            // 
            CollectionPanel.Controls.Add(SortLabel);
            CollectionPanel.Controls.Add(NameSearchButton);
            CollectionPanel.Controls.Add(NameSearchBox);
            CollectionPanel.Controls.Add(ShowDetailsButton);
            CollectionPanel.Controls.Add(PageLabel);
            CollectionPanel.Controls.Add(NextPageButton);
            CollectionPanel.Controls.Add(PreviousPageButton);
            CollectionPanel.Controls.Add(UnwatchedOnlyCheckBox);
            CollectionPanel.Controls.Add(SortOptions);
            CollectionPanel.Controls.Add(ManageMovieButton);
            CollectionPanel.Controls.Add(CollectionMoviesList);
            CollectionPanel.Controls.Add(YourCollectionLabel);
            CollectionPanel.Location = new Point(109, 12);
            CollectionPanel.Name = "CollectionPanel";
            CollectionPanel.Size = new Size(661, 426);
            CollectionPanel.TabIndex = 3;
            // 
            // SortLabel
            // 
            SortLabel.AutoSize = true;
            SortLabel.Location = new Point(4, 55);
            SortLabel.Name = "SortLabel";
            SortLabel.Size = new Size(47, 15);
            SortLabel.TabIndex = 21;
            SortLabel.Text = "Sort by:";
            // 
            // NameSearchButton
            // 
            NameSearchButton.Location = new Point(496, 55);
            NameSearchButton.Name = "NameSearchButton";
            NameSearchButton.Size = new Size(75, 23);
            NameSearchButton.TabIndex = 20;
            NameSearchButton.Text = "Search";
            NameSearchButton.UseVisualStyleBackColor = true;
            NameSearchButton.Click += NameSearchButton_Click;
            // 
            // NameSearchBox
            // 
            NameSearchBox.Location = new Point(450, 26);
            NameSearchBox.Name = "NameSearchBox";
            NameSearchBox.PlaceholderText = "Movie Title";
            NameSearchBox.Size = new Size(166, 23);
            NameSearchBox.TabIndex = 19;
            // 
            // ShowDetailsButton
            // 
            ShowDetailsButton.Location = new Point(268, 389);
            ShowDetailsButton.Name = "ShowDetailsButton";
            ShowDetailsButton.Size = new Size(122, 23);
            ShowDetailsButton.TabIndex = 18;
            ShowDetailsButton.Text = "Details";
            ShowDetailsButton.UseVisualStyleBackColor = true;
            ShowDetailsButton.Click += ShowDetailsButton_Click;
            // 
            // PageLabel
            // 
            PageLabel.AutoSize = true;
            PageLabel.Location = new Point(578, 331);
            PageLabel.Name = "PageLabel";
            PageLabel.Size = new Size(38, 15);
            PageLabel.TabIndex = 17;
            PageLabel.Text = "label1";
            // 
            // NextPageButton
            // 
            NextPageButton.Location = new Point(138, 323);
            NextPageButton.Name = "NextPageButton";
            NextPageButton.Size = new Size(75, 23);
            NextPageButton.TabIndex = 16;
            NextPageButton.Text = "Next";
            NextPageButton.UseVisualStyleBackColor = true;
            NextPageButton.Click += NextPageButton_Click;
            // 
            // PreviousPageButton
            // 
            PreviousPageButton.Location = new Point(57, 323);
            PreviousPageButton.Name = "PreviousPageButton";
            PreviousPageButton.Size = new Size(75, 23);
            PreviousPageButton.TabIndex = 15;
            PreviousPageButton.Text = "Previous";
            PreviousPageButton.UseVisualStyleBackColor = true;
            PreviousPageButton.Click += PreviousPageButton_Click;
            // 
            // UnwatchedOnlyCheckBox
            // 
            UnwatchedOnlyCheckBox.AutoSize = true;
            UnwatchedOnlyCheckBox.Location = new Point(57, 26);
            UnwatchedOnlyCheckBox.Name = "UnwatchedOnlyCheckBox";
            UnwatchedOnlyCheckBox.Size = new Size(150, 19);
            UnwatchedOnlyCheckBox.TabIndex = 14;
            UnwatchedOnlyCheckBox.Text = "Show not watched only";
            UnwatchedOnlyCheckBox.UseVisualStyleBackColor = true;
            UnwatchedOnlyCheckBox.CheckedChanged += UnwatchedOnlyCheckBox_CheckedChanged;
            // 
            // SortOptions
            // 
            SortOptions.DropDownStyle = ComboBoxStyle.DropDownList;
            SortOptions.FormattingEnabled = true;
            SortOptions.Items.AddRange(new object[] { "Title", "Year", "Run Time", "Rating" });
            SortOptions.Location = new Point(57, 52);
            SortOptions.Name = "SortOptions";
            SortOptions.Size = new Size(121, 23);
            SortOptions.TabIndex = 13;
            SortOptions.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // ManageMovieButton
            // 
            ManageMovieButton.Location = new Point(268, 360);
            ManageMovieButton.Name = "ManageMovieButton";
            ManageMovieButton.Size = new Size(122, 23);
            ManageMovieButton.TabIndex = 12;
            ManageMovieButton.Text = "Manage";
            ManageMovieButton.UseVisualStyleBackColor = true;
            ManageMovieButton.Click += ManageMovieButton_Click;
            // 
            // CollectionMoviesList
            // 
            CollectionMoviesList.FormattingEnabled = true;
            CollectionMoviesList.Location = new Point(57, 88);
            CollectionMoviesList.Name = "CollectionMoviesList";
            CollectionMoviesList.Size = new Size(559, 229);
            CollectionMoviesList.TabIndex = 1;
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
            // ExitButton
            // 
            ExitButton.Location = new Point(12, 296);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(75, 33);
            ExitButton.TabIndex = 6;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SearchPanel);
            Controls.Add(CollectionPanel);
            Controls.Add(ExitButton);
            Controls.Add(CollectionPanelButton);
            Controls.Add(SearchPanelButton);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainMenu";
            SearchPanel.ResumeLayout(false);
            SearchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MoviePoster).EndInit();
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
        private Panel CollectionPanel;
        private Label YourCollectionLabel;
        private Label DirectorLabel;
        private Label GenreLabel;
        private Label RunTimeLabel;
        private Label ReleaseYearLabel;
        private Button AddToCollectionButton;
        private ListBox CollectionMoviesList;
        private Button ManageMovieButton;
        private Label PlotLabel;
        private PictureBox MoviePoster;
        private ComboBox SortOptions;
        private CheckBox UnwatchedOnlyCheckBox;
        private Button NextPageButton;
        private Button PreviousPageButton;
        private Label PageLabel;
        private Button ShowDetailsButton;
        private Button NameSearchButton;
        private TextBox NameSearchBox;
        private Button ExitButton;
        private Label SortLabel;
        private Label TotalSeasonsLabel;
    }
}