namespace Movie_Manager.Forms
{
    partial class Login
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
            ApiKeyLabel = new Label();
            label1 = new Label();
            ApiKeyBox = new TextBox();
            PasswordBox = new TextBox();
            LoginButton = new Button();
            SuspendLayout();
            // 
            // ApiKeyLabel
            // 
            ApiKeyLabel.AutoSize = true;
            ApiKeyLabel.Location = new Point(3, 88);
            ApiKeyLabel.Name = "ApiKeyLabel";
            ApiKeyLabel.Size = new Size(88, 15);
            ApiKeyLabel.TabIndex = 0;
            ApiKeyLabel.Text = "OMDb Api Key:";
            // 
            // label1
            // 
            label1.Location = new Point(3, 120);
            label1.Name = "label1";
            label1.Size = new Size(174, 56);
            label1.TabIndex = 1;
            label1.Text = "MySQL Workbench password:";
            // 
            // ApiKeyBox
            // 
            ApiKeyBox.Location = new Point(183, 85);
            ApiKeyBox.Name = "ApiKeyBox";
            ApiKeyBox.Size = new Size(100, 23);
            ApiKeyBox.TabIndex = 2;
            // 
            // PasswordBox
            // 
            PasswordBox.Location = new Point(183, 117);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(100, 23);
            PasswordBox.TabIndex = 3;
            PasswordBox.UseSystemPasswordChar = true;
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(130, 189);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(75, 23);
            LoginButton.TabIndex = 4;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 236);
            Controls.Add(LoginButton);
            Controls.Add(PasswordBox);
            Controls.Add(ApiKeyBox);
            Controls.Add(label1);
            Controls.Add(ApiKeyLabel);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ApiKeyLabel;
        private Label label1;
        private TextBox ApiKeyBox;
        private TextBox PasswordBox;
        private Button LoginButton;
    }
}