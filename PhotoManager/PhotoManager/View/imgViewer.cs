using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoManager.View
{
	public partial class imgViewer : Form
	{

		public imgViewer()
		{
			InitializeComponent();
			this.panel.Size = Screen.FromControl(this).Bounds.Size;
		}

		public Image ImgBox
		{
			set
			{
				this.pictureBox.Image = value;
				//if (value.Size.Width > Screen.FromControl(this).Bounds.Size.Width)
				//{
				//	int scale = Screen.FromControl(this).Bounds.Size.Width / value.Size.Width;
				//	this.pictureBox.Width = value.Size.Width * scale;
				//	this.pictureBox.Height = value.Size.Height * scale;
				//}
				//else
					this.pictureBox.Size = value.Size;
			}
		}

		private void imgViewer_FormClosing(object sender, FormClosingEventArgs e)
		{
			if(this.pictureBox.Image != null)
			{
				pictureBox.Dispose();
			}
		}
	}
}
