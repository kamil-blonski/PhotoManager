using System;
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
	public partial class Main : Form, IMainViev
	{
        #region Fields
        private List<String> fileNames = new List<string>();
		private static Main instance = null;
		private List<Album> albums;
		private List<Photo> photos; //from db
		private List<Image> ImageList;
		private bool IfAlbumSelected = false;
		private int indexForMiniPhoto = 0; //indekser do wyświetlania miniaturek
		#endregion Fields

		#region Events
		public event Action<string, Photo> AddPhotoEvent;
		public event Func<List<Album>> GetAlbums;
		public event Action<Album> GetPhotosFromDB;
		public event Action<string> SaveAlbum;
		public event Action GetUserName;
		public event Action GetCurrentAlbum;
        public event Action<List<Photo>> DeletePhoto;
        public event Action GetDescriptionForAlbum;
        #endregion Events

        #region Constructors
        private Main()
		{
			InitializeComponent();
		}

		#endregion Constructors

		#region Properties
		public static Main InstanceForm1
		{
			get
			{
				if (instance == null || instance.IsDisposed)
					instance = new Main();
				return instance;
			}
		}
		public static Main Instance
		{
			set { instance = value; }
		}
		public IAddAlbumView IAddAlbumView
		{
			get
			{
				return AddAlbum.AddAlbumInstance;
			}
		}
		public List<Photo> PhotoList
		{
			set { photos = value; }
		}
		public string UserName
		{
			set { UserNameInfoLabel.Text += value; }
		}
		public string AlbumName
		{
			set { AlbumInfoLabel.Text = value; }
		}
        public string AlbumDescription
        {
            set { AlbumDescriptionLabel.Text = "Description: " + value; }
        }
		#endregion Properties

		#region MenuMethods
		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (albumListToolStripMenuItem.DropDownItems.Count == 0)
			{
				ShowMessage(false, "Create an album first!");
				return;
			}
			if (!IfAlbumSelected)
			{
				ShowMessage(false, "Select an album first!");
				return;
			}

			using (OpenFileDialog ofd = new OpenFileDialog()
			{
				Multiselect = true,
				ValidateNames = true,
				Filter = "JPEG|*.jpg"
			})
			{
				if (ofd.ShowDialog() == DialogResult.OK)
				{
					foreach (string fileName in ofd.FileNames)
					{
                        FileInfo fi = new FileInfo(fileName);
                        if (FileWithThisNameExists(fi.Name))
                        {
                            
                            fileNames.Add(fi.Name);

                            if (AddPhotoEvent != null)
                            {
                                AddPhotoEvent(fi.FullName, new Photo(null, fi.Name, fi.CreationTime, ImageFormat.Jpeg, fi.Length)); //albums bo albumsComboBox zawierajątylko NAME 
                            }
                        }
                        else
                            MessageBox.Show("File with name " + fi.Name + " is already exists in this album", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
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
			if (imgListView.FocusedItem != null)
			{
				using (imgViewer iv = new imgViewer())
				{

					Image img2 = ImageList[imgListView.FocusedItem.Index];
					iv.ImgBox = img2;
					iv.ShowDialog();
				}
			}
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			if (GetUserName != null)
				GetUserName();
			albums = new List<Album>();
			albums = GetAlbums();
			albumListToolStripMenuItem.DropDownItems.Clear();
			foreach (var item in albums)
			{
				albumListToolStripMenuItem.DropDownItems.Add(item.Name);
			}
			if (albumListToolStripMenuItem.DropDownItems.Count < 1)
				albumListToolStripMenuItem.Enabled = false;
			else
			{
				albumListToolStripMenuItem.Enabled = true;
				LoadPhotosForAlbumWithIndex(0);
			}

		}
		public void AddNewAlbumToList(Album album)
		{
			albumListToolStripMenuItem.DropDownItems.Add(album.Name);
			albumListToolStripMenuItem.Enabled = true;
		}
		public void AddNewPhotoToList(Photo newPhoto)
		{
			imageListMin.Images.Add(newPhoto.Image);
			ImageList.Add(newPhoto.Image);
			imgListView.Items.Add(newPhoto.Name, indexForMiniPhoto);
            fileNames.Add(newPhoto.Name);
			indexForMiniPhoto++;
		}	
		private void LoadPhotosForAlbumWithIndex(int index)
		{
                if (photos != null)
                    photos.Clear();
                IfAlbumSelected = true;
                fileNames.Clear();  //nazwy plików są odpowiednie
                imgListView.Items.Clear(); //czyszczenie listy obrazków
                imageListMin.Images.Clear(); //miniaturki są takie jak powinny być
                ImageList = new List<Image>();
                GetPhotosFromDB(albums[index]);
                indexForMiniPhoto = 0;
                foreach (Photo photo in photos)
                {
                    imageListMin.Images.Add(photo.Image);
                    ImageList.Add(photo.Image);
                    fileNames.Add(photo.Name);
                    imgListView.Items.Add(photo.Name, indexForMiniPhoto);
                    indexForMiniPhoto++;
                }
                if (GetCurrentAlbum != null)
                    GetCurrentAlbum();
                if (GetDescriptionForAlbum != null)
                    GetDescriptionForAlbum();
		}
		private void albumListToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			LoadPhotosForAlbumWithIndex(albumListToolStripMenuItem.DropDownItems.IndexOf(e.ClickedItem));
		}
		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
            DialogResult result = MessageBox.Show("Do you want co close an application?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult.Yes == result)
            {
                this.Dispose();
                Application.Exit();
            }
            else
                e.Cancel = true;
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want co close an application?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(DialogResult.Yes == result)
            {
                this.Dispose();
                Application.Exit();
            }
        }
		private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
		{
            DialogResult result = MessageBox.Show("Do you want to log out?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult.Yes == result)
            {
                this.Dispose();
                Application.Restart();
            }         
		}		
		private void saveAlbumToolStripMenuItem_Click(object sender, EventArgs e)
        {    
            if(albumListToolStripMenuItem.Enabled == false)
            {
                MessageBox.Show("This album does not comtain photos to save.!", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }      
            using (FolderBrowserDialog ofd = new FolderBrowserDialog())
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    string destinationPath = ofd.SelectedPath;
                    if (SaveAlbum != null)
                        SaveAlbum(destinationPath);
                }
            }
        }
        private bool FileWithThisNameExists(string newFileName)
        {
            foreach(string fName in fileNames)
            {
                FileInfo fi = new FileInfo(fName);
                if (newFileName.Equals(fName))
                    return false;
            }
            return true;
        }
        private void imgListView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ImageMenuStrip.Show(Cursor.Position);
            }
        }
        private void delateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int amount = imgListView.SelectedItems.Count;
            if (imgListView.SelectedItems.Count == 0)
                return;
            List<Photo> photosToDelete = new List<Photo>();
            List<int> index = new List<int>();
            for (int i = 0; i < amount; i++)
                index.Add(imgListView.SelectedItems[i].Index);

            for (int i = 0; i < amount; i++) //powinno być w modelu przez event 
            {
                photosToDelete.Add(photos[index[i] - i]);
                imgListView.Items.RemoveAt(index[i] - i);
                imageListMin.Images.RemoveAt(index[i]- i);
                ImageList.RemoveAt(index[i] - i);
                fileNames.RemoveAt(index[i] - i);
                photos.Remove(photos[index[i] - i]);
                indexForMiniPhoto--;
            }

            if (DeletePhoto != null)
                DeletePhoto(photosToDelete);
            
        }
        #endregion OtherMethods
    }
}
