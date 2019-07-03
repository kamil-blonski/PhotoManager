using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using System.Windows.Forms;
using PhotoManager.Model;

namespace PhotoManager.View
{
    public partial class AddAlbum : Form, IAddAlbumView
    {
        #region Fields
        private static AddAlbum instance = null;
        #endregion Fields

        #region Events
        public event Action<Album> AddAlbumEvent;
        public event Action RefreshAlbumListInForm1Event;
        #endregion Events

        #region Constructors
        private AddAlbum()
        {
            InitializeComponent();
            TypeComboBox.Items.Add("Private");
            TypeComboBox.Items.Add("Public");
            TypeComboBox.SelectedIndex = 0;
        }
        #endregion Constructors

        #region Properties
        public static AddAlbum AddAlbumInstance
        {
            get
            {
                if (instance == null)
                    instance = new AddAlbum();
                return instance;
            }
        }
        #endregion Properties

        #region Methods
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(NameTextBox.Text.Trim()) || string.IsNullOrEmpty(DescriptionRTextBox.Text.Trim())))
            {
                if (AddAlbumEvent != null)
                {
                    AddAlbumEvent(new Album(null, NameTextBox.Text, DateTime.Now, DescriptionRTextBox.Text, TypeComboBox.SelectedItem.ToString()));
                    if (RefreshAlbumListInForm1Event != null)
                        RefreshAlbumListInForm1Event();
                }
            }
            else
            {
                ShowMessage(false, "Name of album and description required.");
            }
   
        }
        public void ShowMessage(bool success, string message)
        {
            MessageBox.Show(message, success ? "Message" : "Error", MessageBoxButtons.OK);
        }
        public void ClearTextBoxes()
        {
            NameTextBox.Text = string.Empty;
            DescriptionRTextBox.Text = string.Empty;
        }

        #endregion Methods
    }
}
