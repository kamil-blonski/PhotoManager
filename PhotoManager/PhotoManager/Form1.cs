﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PhotoManager.View;
using PhotoManager.Model;
using System.Drawing.Imaging;

namespace PhotoManager
{
    public partial class Form1 : Form, IForm1View
    {
        #region Fields
        private List<String> fileNames = new List<string>();
		private Size screenSize;
		private int X;
		private int Y;
        private static Form1 instance = null;
		private List<Album> albums;
        #endregion Fields

        #region Events
        public event Action<string, Photo, Album> AddPhotoEvent;
		public event Func<List<Album>> GetAlbums;
       // public event Action<Album> RefreshAlbumList;
        #endregion Events

        #region Constructors
        private Form1()
        {
            InitializeComponent();
            this.screenSize = Screen.FromControl(this).Bounds.Size;
            X = screenSize.Width - 100;
            Y = screenSize.Height - 100;
            this.imgListView.Size = new Size(X, Y);
        }
        #endregion Constructors

        #region Properties
        public static Form1 InstanceForm1
        {
            get
            {
                if (instance == null)
                    instance = new Form1();
                return instance;
            }
        }

        public IAddAlbumView IAddAlbumView
        {
            get
            {
                return AddAlbum.AddAlbumInstance;
            }
        }
        #endregion Properties

        #region MenuMethods
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog ofd = new OpenFileDialog() { Multiselect = true,
			ValidateNames = true, Filter = "JPEG|*.jpg"})
			{
				if(ofd.ShowDialog() == DialogResult.OK)
				{
					fileNames.Clear();
					imgListView.Items.Clear(); //czyszczenie listy obrazków
					foreach(string fileName in ofd.FileNames)
					{
						FileInfo fi = new FileInfo(fileName);
						fileNames.Add(fi.FullName);
						imgListView.Items.Add(fi.Name, 0);//dodanie obrazka do listy

                        if (AddPhotoEvent != null)
                        { //int? id, string name, DateTime creationDate, ImageFormat format, Size photoSize

                            AddPhotoEvent(fi.FullName, new Photo(null, fi.Name, fi.CreationTime, ImageFormat.Jpeg,  fi.Length), albums[albumsComboBox.SelectedIndex]); //albums bo albumsComboBox zawierajątylko NAME 
                        }
					}
				}
			}
		}

        private void createNewAlbumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAlbum.AddAlbumInstance.ShowDialog();

        }

        #endregion MenuMethods

        #region OtherMethods
        public void ShowMessage(bool success, string message)
        {
            MessageBox.Show(message, success ? "Message" : "Error", MessageBoxButtons.OK);
        }
        private void imgListView_ItemActivate(object sender, EventArgs e)
        {
            Console.WriteLine("powiększenie");
            //powiększenie miniaturki
            if (imgListView.FocusedItem != null)
            {
                using (imgViewer iv = new imgViewer())
                {
                    Image img = Image.FromFile(fileNames[imgListView.FocusedItem.Index]);
                    iv.ImgBox = img;
                    iv.ShowDialog();
                    Console.WriteLine("pomniejszenie");
                    //zamknięcie miniaturki
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
		{
            Console.WriteLine("Pobieram albumy");
			albums = new List<Album>();
			
			albums = GetAlbums();
			
			albumsComboBox.Items.Clear();
			foreach (var item in albums)
			{
				albumsComboBox.Items.Add(item.Name);
			}
            if(albumsComboBox.Items.Count > 1)
                albumsComboBox.SelectedItem = albumsComboBox.Items[0];

        }

        public void AddNewAlbumToList(Album album)
        {
            albumsComboBox.Items.Add(album.Name);
        }

        #endregion OtherMethods

        private void albumsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void albumsComboBox_Click(object sender, EventArgs e)
        {

        }

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
	}
}
