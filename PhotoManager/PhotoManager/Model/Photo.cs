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
		private int? id;
		private string name;
		private DateTime creationDate;
		private string description;
		private ImageFormat format;
		private Size photoSize;
        private string formatS;
		//private string path;


		public Photo(int? id, string name, DateTime creationDate,
			string description, ImageFormat format, Size photoSize)
		{
			this.id = id;
			this.name = name;
			this.description = description;
			this.format = format;
			this.photoSize = photoSize;
			this.creationDate = creationDate;
		}

        public Photo(int? id, string name, DateTime creationDate,
    string description, string format, Size photoSize)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.formatS = format;
            this.photoSize = photoSize;
            this.creationDate = creationDate;
        }

        #region Properties
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
        public string Description
        {
            set { description = value; }
            get { return description; }
        }
        public string Format
        {
            set { formatS = value; }
            get { return formatS; }
        }
        public Size PhotoSize
        {
            set { photoSize = value; }
            get { return photoSize; }
        }

        #endregion Properties


        /*public void EncodePhoto()
		{
			
		}*/

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

		public string DecodePhoto()
		{
            return "";
		}
	}
}
