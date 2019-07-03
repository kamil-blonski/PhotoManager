using System.Drawing;
using System.Windows.Forms;

namespace PhotoManager.View
{
    public partial class imgViewer : Form
	{

        #region Constructors
        public imgViewer()
		{      
            InitializeComponent();
		}
        #endregion Constructors

        #region Methods
        public Image ImgBox
		{
			set
			{
				this.pictureBox.Image = value;
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
        #endregion Methods
    }
}
