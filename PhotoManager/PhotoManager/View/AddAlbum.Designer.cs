namespace PhotoManager.View
{
    partial class AddAlbum
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
            this.AddAlbumGroupBox = new System.Windows.Forms.GroupBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.DescriptionRTextBox = new System.Windows.Forms.RichTextBox();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.AddAlbumGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddAlbumGroupBox
            // 
            this.AddAlbumGroupBox.Controls.Add(this.AddButton);
            this.AddAlbumGroupBox.Controls.Add(this.DescriptionRTextBox);
            this.AddAlbumGroupBox.Controls.Add(this.TypeComboBox);
            this.AddAlbumGroupBox.Controls.Add(this.NameTextBox);
            this.AddAlbumGroupBox.Controls.Add(this.TypeLabel);
            this.AddAlbumGroupBox.Controls.Add(this.DescriptionLabel);
            this.AddAlbumGroupBox.Controls.Add(this.NameLabel);
            this.AddAlbumGroupBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddAlbumGroupBox.Location = new System.Drawing.Point(12, 12);
            this.AddAlbumGroupBox.Name = "AddAlbumGroupBox";
            this.AddAlbumGroupBox.Size = new System.Drawing.Size(504, 280);
            this.AddAlbumGroupBox.TabIndex = 0;
            this.AddAlbumGroupBox.TabStop = false;
            this.AddAlbumGroupBox.Text = "Add new album";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(410, 236);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(88, 38);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DescriptionRTextBox
            // 
            this.DescriptionRTextBox.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DescriptionRTextBox.Location = new System.Drawing.Point(6, 134);
            this.DescriptionRTextBox.Name = "DescriptionRTextBox";
            this.DescriptionRTextBox.Size = new System.Drawing.Size(492, 96);
            this.DescriptionRTextBox.TabIndex = 7;
            this.DescriptionRTextBox.Text = "";
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Location = new System.Drawing.Point(83, 70);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(173, 27);
            this.TypeComboBox.TabIndex = 6;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NameTextBox.Location = new System.Drawing.Point(83, 37);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(415, 27);
            this.NameTextBox.TabIndex = 5;
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(6, 73);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(55, 22);
            this.TypeLabel.TabIndex = 4;
            this.TypeLabel.Text = "Type:";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(6, 109);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(107, 22);
            this.DescriptionLabel.TabIndex = 3;
            this.DescriptionLabel.Text = "Desctiption:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(6, 40);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(62, 22);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name:";
            // 
            // AddAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 304);
            this.Controls.Add(this.AddAlbumGroupBox);
            this.Name = "AddAlbum";
            this.Text = "AddAlbum";
            this.AddAlbumGroupBox.ResumeLayout(false);
            this.AddAlbumGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AddAlbumGroupBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.RichTextBox DescriptionRTextBox;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label NameLabel;
    }
}