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
        public string test = " XD";
 
           

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

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (AddAlbumEvent != null)
                AddAlbumEvent(new Album(NameTextBox.Text, TypeComboBox.SelectedItem.ToString(), DescriptionRTextBox.Text));
        }

        public string Test
        {
            get { return test; }
        }
    }
}
