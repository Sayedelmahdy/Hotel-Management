namespace Hotel_Manager
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
            usernameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            signinButton = new System.Windows.Forms.Button();
            passwordTextBox = new System.Windows.Forms.TextBox();
            usernameTextBox = new System.Windows.Forms.TextBox();
            LicenseCallButton = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.ForeColor = System.Drawing.Color.Black;
            usernameLabel.Location = new System.Drawing.Point(190, 110);
            usernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(60, 15);
            usernameLabel.TabIndex = 3;
            usernameLabel.Text = "Username";
            usernameLabel.Visible = false;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(189, 177);
            passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(57, 15);
            passwordLabel.TabIndex = 5;
            passwordLabel.Text = "Password";
            passwordLabel.Visible = false;
            // 
            // signinButton
            // 
            signinButton.Location = new System.Drawing.Point(192, 269);
            signinButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            signinButton.Name = "signinButton";
            signinButton.Size = new System.Drawing.Size(237, 35);
            signinButton.TabIndex = 6;
            signinButton.Text = "Sign in";
            signinButton.Click += signinButton_Click;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new System.Drawing.Point(191, 202);
            passwordTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new System.Drawing.Size(237, 23);
            passwordTextBox.TabIndex = 2;
            passwordTextBox.Click += passwordTextBox_Click;
            // 
            // usernameTextBox
            // 
            usernameTextBox.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            usernameTextBox.Location = new System.Drawing.Point(191, 138);
            usernameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new System.Drawing.Size(237, 23);
            usernameTextBox.TabIndex = 0;
            usernameTextBox.Click += usernameTextBox_Click;
            // 
            // LicenseCallButton
            // 
            LicenseCallButton.Location = new System.Drawing.Point(546, 408);
            LicenseCallButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            LicenseCallButton.Name = "LicenseCallButton";
            LicenseCallButton.Size = new System.Drawing.Size(56, 27);
            LicenseCallButton.TabIndex = 7;
            LicenseCallButton.Text = "License";
            LicenseCallButton.Click += LicenseCallButton_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(602, 435);
            Controls.Add(LicenseCallButton);
            Controls.Add(passwordTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Controls.Add(signinButton);
            Controls.Add(usernameTextBox);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "Login";
            Text = "Login";
            FormClosing += login_FormClosing;
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Button signinButton;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button LicenseCallButton;


    }
}

