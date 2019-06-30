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

namespace PhotoManager
{
    public partial class Form1 : Form
    {
		private List<String> fileNames = new List<string>();
		private Size screenSize;
		private int X;
		private int Y;

        public Form1()
        {
            InitializeComponent();
			this.screenSize = Screen.FromControl(this).Bounds.Size;
			X = screenSize.Width - 100;
			Y = screenSize.Height - 100;
			this.imgListView.Size = new Size(X, Y);

			//Test();
		}

		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog ofd = new OpenFileDialog() { Multiselect = true,
			ValidateNames = true, Filter = "JPEG|*.jpg"})
			{
				if(ofd.ShowDialog() == DialogResult.OK)
				{
					fileNames.Clear();
					imgListView.Items.Clear();
					foreach(string fileName in ofd.FileNames)
					{
						FileInfo fi = new FileInfo(fileName);
						fileNames.Add(fi.FullName);
						imgListView.Items.Add(fi.Name, 0);
					}
				}
			}
		}

		private void imgListView_ItemActivate(object sender, EventArgs e)
		{
			if(imgListView.FocusedItem != null)
			{
				using (imgViewer iv = new imgViewer())
				{
					Image img = Image.FromFile(fileNames[imgListView.FocusedItem.Index]);
					iv.ImgBox = img;
					iv.ShowDialog();
				}
			}
		}

	}
}
