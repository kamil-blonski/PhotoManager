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
        public event Action<Album> AddAlbumEvent;
        private static AddAlbum instance = null;
        private AddAlbum()
        {
            InitializeComponent();
            TypeComboBox.Items.Add("Private");
            TypeComboBox.Items.Add("Public");
            TypeComboBox.SelectedIndex = 0;
        }

        public static AddAlbum AddAlbumInstance
        {
            get
            {
                if (instance == null)
                    instance = new AddAlbum();
                return instance;
            }
        }

        #region Methods
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(NameTextBox.Text.Trim()) || string.IsNullOrEmpty(DescriptionRTextBox.Text.Trim())))
            {
                if (AddAlbumEvent != null)
                {
                    AddAlbumEvent(new Album(NameTextBox.Text, TypeComboBox.SelectedItem.ToString(), DescriptionRTextBox.Text, DateTime.Now));
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
