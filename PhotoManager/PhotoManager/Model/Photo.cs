using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Media.Imaging;
using System.IO;
/*
https://docs.microsoft.com/en-us/dotnet/framework/wpf/graphics-multimedia/how-to-encode-and-decode-a-jpeg-image
*/

namespace PhotoManager.Model
{
	public class Photo
	{
		#region Fields
		private int? id;
		private string name;
		private DateTime creationDate;
		private ImageFormat format;
		private double photoSize;
		private Image img;
		#endregion Fields

		#region Constructors

		public Photo(Image img)
		{
			this.img = img;
		}

		public Photo(int? id, string name, DateTime creationDate,
		 ImageFormat format, double photoSize)
		{
			this.id = id;
			this.name = name;
			this.format = format;
			this.photoSize = photoSize;
			this.creationDate = creationDate;
		}
		#endregion Constructors

		#region Properties

		public Image Image
		{
			get { return this.img; }
		}


        public int? ID
        {
            set { id = value; }
            get { return id; }
        }
        public string Name
        {
            set { name = value;}
            get { return name; }
        }
        public DateTime CreationDate
        {
            set { creationDate = value; }
            get { return creationDate; }
        }
        public ImageFormat Format
        {
            set { format = value; }
            get { return format; }
        }
        public double PhotoSize
        {
            set { photoSize = value; }
            get { return photoSize; }
        }

        #endregion Properties

        #region Methods
        public string EncodePhoto(string path)
        {
            FileStream fStream = new FileStream(path, FileMode.Open, FileAccess.Read);
            byte[] data = new byte[fStream.Length];
            fStream.Read(data, 0, (int)fStream.Length);
            fStream.Close();

            string hex = BitConverter.ToString(data);
            hex = hex.Replace("-", "");
            return hex;
        }

		public static Image DecodePhoto(string hexString)
		{
			int bytesCount = (hexString.Length) / 2;
			byte[] bytes = new byte[bytesCount];
			for (int x = 0; x < bytesCount; ++x)
			{
				bytes[x] = Convert.ToByte(hexString.Substring(x * 2, 2), 16);
			}

			//return bytes;
			using (var ms = new MemoryStream(bytes))
			{
				return Image.FromStream(ms);
			}
		}

        #endregion Methods
    }
}
