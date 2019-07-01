using System;

namespace PhotoManager
{
    partial class Form1
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.imgList = new System.Windows.Forms.ImageList(this.components);
			this.imgListView = new System.Windows.Forms.ListView();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AddAlbumButton = new System.Windows.Forms.Button();
			this.albumsComboBox = new System.Windows.Forms.ComboBox();
			this.menuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// imgList
			// 
			this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
			this.imgList.TransparentColor = System.Drawing.Color.Transparent;
			this.imgList.Images.SetKeyName(0, "IMG_8274.JPG");
			this.imgList.Images.SetKeyName(1, "IMG_8285.JPG");
			this.imgList.Images.SetKeyName(2, "IMG_8293.JPG");
			// 
			// imgListView
			// 
			this.imgListView.LargeImageList = this.imgList;
			this.imgListView.Location = new System.Drawing.Point(12, 40);
			this.imgListView.Name = "imgListView";
			this.imgListView.Size = new System.Drawing.Size(568, 223);
			this.imgListView.TabIndex = 0;
			this.imgListView.UseCompatibleStateImageBehavior = false;
			this.imgListView.ItemActivate += new System.EventHandler(this.imgListView_ItemActivate);
			// 
			// menuStrip
			// 
			this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(592, 24);
			this.menuStrip.TabIndex = 1;
			this.menuStrip.Text = "menuStrip1";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(50, 20);
			this.toolStripMenuItem1.Text = "Menu";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.openToolStripMenuItem.Text = "Open";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// AddAlbumButton
			// 
			this.AddAlbumButton.Location = new System.Drawing.Point(101, 5);
			this.AddAlbumButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.AddAlbumButton.Name = "AddAlbumButton";
			this.AddAlbumButton.Size = new System.Drawing.Size(91, 30);
			this.AddAlbumButton.TabIndex = 2;
			this.AddAlbumButton.Text = "Add Album";
			this.AddAlbumButton.UseVisualStyleBackColor = true;
			this.AddAlbumButton.Click += new System.EventHandler(this.AddAlbumButton_Click);
			// 
			// albumsComboBox
			// 
			this.albumsComboBox.FormattingEnabled = true;
			this.albumsComboBox.Location = new System.Drawing.Point(244, 11);
			this.albumsComboBox.Name = "albumsComboBox";
			this.albumsComboBox.Size = new System.Drawing.Size(121, 21);
			this.albumsComboBox.TabIndex = 3;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(592, 275);
			this.Controls.Add(this.albumsComboBox);
			this.Controls.Add(this.AddAlbumButton);
			this.Controls.Add(this.imgListView);
			this.Controls.Add(this.menuStrip);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "Photo Manager";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.ImageList imgList;
		private System.Windows.Forms.ListView imgListView;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.Button AddAlbumButton;
		private System.Windows.Forms.ComboBox albumsComboBox;
	}
}

