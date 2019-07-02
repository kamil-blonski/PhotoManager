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
			this.createNewAlbumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.albumsComboBox = new System.Windows.Forms.ComboBox();
			this.SelectAlbumLabel = new System.Windows.Forms.Label();
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
            this.openToolStripMenuItem,
            this.createNewAlbumToolStripMenuItem});
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(50, 20);
			this.toolStripMenuItem1.Text = "Menu";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
			this.openToolStripMenuItem.Text = "Open";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// createNewAlbumToolStripMenuItem
			// 
			this.createNewAlbumToolStripMenuItem.Name = "createNewAlbumToolStripMenuItem";
			this.createNewAlbumToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
			this.createNewAlbumToolStripMenuItem.Text = "Create New Album";
			this.createNewAlbumToolStripMenuItem.Click += new System.EventHandler(this.createNewAlbumToolStripMenuItem_Click);
			// 
			// albumsComboBox
			// 
			this.albumsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.albumsComboBox.FormattingEnabled = true;
			this.albumsComboBox.Location = new System.Drawing.Point(459, 11);
			this.albumsComboBox.Name = "albumsComboBox";
			this.albumsComboBox.Size = new System.Drawing.Size(121, 21);
			this.albumsComboBox.TabIndex = 3;
			this.albumsComboBox.SelectedIndexChanged += new System.EventHandler(this.albumsComboBox_SelectedIndexChanged);
			this.albumsComboBox.Click += new System.EventHandler(this.albumsComboBox_Click);
			// 
			// SelectAlbumLabel
			// 
			this.SelectAlbumLabel.AutoSize = true;
			this.SelectAlbumLabel.Location = new System.Drawing.Point(384, 13);
			this.SelectAlbumLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.SelectAlbumLabel.Name = "SelectAlbumLabel";
			this.SelectAlbumLabel.Size = new System.Drawing.Size(71, 13);
			this.SelectAlbumLabel.TabIndex = 4;
			this.SelectAlbumLabel.Text = "Select album:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(592, 275);
			this.Controls.Add(this.SelectAlbumLabel);
			this.Controls.Add(this.albumsComboBox);
			this.Controls.Add(this.imgListView);
			this.Controls.Add(this.menuStrip);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "Photo Manager";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
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
		private System.Windows.Forms.ComboBox albumsComboBox;
        private System.Windows.Forms.ToolStripMenuItem createNewAlbumToolStripMenuItem;
        private System.Windows.Forms.Label SelectAlbumLabel;
    }
}

