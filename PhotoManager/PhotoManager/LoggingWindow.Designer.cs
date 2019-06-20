namespace PhotoManager
{
	partial class LoggingWindow
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoggingWindow));
			this.loginLabel = new System.Windows.Forms.Label();
			this.passwordLabel = new System.Windows.Forms.Label();
			this.passwordTextBox = new System.Windows.Forms.TextBox();
			this.loginTextBox = new System.Windows.Forms.TextBox();
			this.loggingGroupBox = new System.Windows.Forms.GroupBox();
			this.logInButton = new System.Windows.Forms.Button();
			this.registerButton = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.loggingGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// loginLabel
			// 
			this.loginLabel.AutoSize = true;
			this.loginLabel.Location = new System.Drawing.Point(6, 26);
			this.loginLabel.Name = "loginLabel";
			this.loginLabel.Size = new System.Drawing.Size(39, 13);
			this.loginLabel.TabIndex = 0;
			this.loginLabel.Text = "Login: ";
			// 
			// passwordLabel
			// 
			this.passwordLabel.AutoSize = true;
			this.passwordLabel.Location = new System.Drawing.Point(6, 50);
			this.passwordLabel.Name = "passwordLabel";
			this.passwordLabel.Size = new System.Drawing.Size(59, 13);
			this.passwordLabel.TabIndex = 1;
			this.passwordLabel.Text = "Password: ";
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.Location = new System.Drawing.Point(94, 52);
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
			this.passwordTextBox.TabIndex = 2;
			// 
			// loginTextBox
			// 
			this.loginTextBox.Location = new System.Drawing.Point(94, 26);
			this.loginTextBox.Name = "loginTextBox";
			this.loginTextBox.Size = new System.Drawing.Size(100, 20);
			this.loginTextBox.TabIndex = 1;
			// 
			// loggingGroupBox
			// 
			this.loggingGroupBox.Controls.Add(this.logInButton);
			this.loggingGroupBox.Controls.Add(this.passwordTextBox);
			this.loggingGroupBox.Controls.Add(this.loginLabel);
			this.loggingGroupBox.Controls.Add(this.passwordLabel);
			this.loggingGroupBox.Controls.Add(this.loginTextBox);
			this.loggingGroupBox.Location = new System.Drawing.Point(120, 96);
			this.loggingGroupBox.Name = "loggingGroupBox";
			this.loggingGroupBox.Size = new System.Drawing.Size(207, 116);
			this.loggingGroupBox.TabIndex = 4;
			this.loggingGroupBox.TabStop = false;
			this.loggingGroupBox.Text = "Log in";
			// 
			// logInButton
			// 
			this.logInButton.Location = new System.Drawing.Point(107, 78);
			this.logInButton.Name = "logInButton";
			this.logInButton.Size = new System.Drawing.Size(87, 23);
			this.logInButton.TabIndex = 3;
			this.logInButton.Text = "Log in";
			this.logInButton.UseVisualStyleBackColor = true;
			this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
			// 
			// registerButton
			// 
			this.registerButton.Location = new System.Drawing.Point(131, 233);
			this.registerButton.Name = "registerButton";
			this.registerButton.Size = new System.Drawing.Size(185, 41);
			this.registerButton.TabIndex = 4;
			this.registerButton.Text = "Register";
			this.registerButton.UseVisualStyleBackColor = true;
			this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Enabled = false;
			this.pictureBox1.Image = global::PhotoManager.Properties.Resources.photo_gallery;
			this.pictureBox1.Location = new System.Drawing.Point(187, 26);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(64, 64);
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			// 
			// LoggingWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(446, 286);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.registerButton);
			this.Controls.Add(this.loggingGroupBox);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "LoggingWindow";
			this.Text = "Photo Manager";
			this.loggingGroupBox.ResumeLayout(false);
			this.loggingGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label loginLabel;
		private System.Windows.Forms.Label passwordLabel;
		private System.Windows.Forms.TextBox passwordTextBox;
		private System.Windows.Forms.TextBox loginTextBox;
		private System.Windows.Forms.GroupBox loggingGroupBox;
		private System.Windows.Forms.Button logInButton;
		private System.Windows.Forms.Button registerButton;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}