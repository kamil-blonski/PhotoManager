using System;

namespace PhotoManager
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.imageListMin = new System.Windows.Forms.ImageList(this.components);
            this.imgListView = new System.Windows.Forms.ListView();
            this.imageListNormal = new System.Windows.Forms.ImageList(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewAlbumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.albumListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageListMin
            // 
            this.imageListMin.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
            this.imageListMin.ImageSize = new System.Drawing.Size(64, 64);
            this.imageListMin.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imgListView
            // 
            this.imgListView.LargeImageList = this.imageListMin;
            this.imgListView.Location = new System.Drawing.Point(16, 52);
            this.imgListView.Margin = new System.Windows.Forms.Padding(4);
            this.imgListView.Name = "imgListView";
            this.imgListView.Size = new System.Drawing.Size(1335, 559);
            this.imgListView.TabIndex = 0;
            this.imgListView.UseCompatibleStateImageBehavior = false;
            this.imgListView.ItemActivate += new System.EventHandler(this.imgListView_ItemActivate);
            // 
            // imageListNormal
            // 
            this.imageListNormal.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListNormal.ImageSize = new System.Drawing.Size(100, 100);
            this.imageListNormal.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.createNewAlbumToolStripMenuItem});
            this.toolStripMenuItem1.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(58, 24);
            this.toolStripMenuItem1.Text = "Menu";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.openToolStripMenuItem.Text = "Add New Photos";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // createNewAlbumToolStripMenuItem
            // 
            this.createNewAlbumToolStripMenuItem.Name = "createNewAlbumToolStripMenuItem";
            this.createNewAlbumToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.createNewAlbumToolStripMenuItem.Text = "Create New Album";
            this.createNewAlbumToolStripMenuItem.Click += new System.EventHandler(this.createNewAlbumToolStripMenuItem_Click);
            // 
            // albumListToolStripMenuItem
            // 
            this.albumListToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.albumListToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.albumListToolStripMenuItem.Name = "albumListToolStripMenuItem";
            this.albumListToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.albumListToolStripMenuItem.Text = "AlbumList";
            this.albumListToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.albumListToolStripMenuItem_DropDownItemClicked);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.albumListToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Margin = new System.Windows.Forms.Padding(5, 10, 0, 10);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1367, 38);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 624);
            this.Controls.Add(this.imgListView);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "Photo Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.ImageList imageListMin;
		private System.Windows.Forms.ListView imgListView;
        private System.Windows.Forms.ImageList imageListNormal;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewAlbumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem albumListToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip;
    }
}

