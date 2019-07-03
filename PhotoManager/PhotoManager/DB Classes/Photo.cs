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
		private Image image;
        #endregion Fields

        #region Constructors
        public Photo(int? id, string name, DateTime creationDate,
        ImageFormat format, double photoSize, Image image)//używany do odkodowania zdjęcia z bazy
        {
            this.id = id;
            this.name = name;
            this.format = format;
            this.photoSize = photoSize;
            this.creationDate = creationDate;
            this.image = image;
        }
        public Photo(int? id, string name, DateTime creationDate,
		 ImageFormat format, double photoSize) //nie ma photoB bo kodowanie zdjęcia następuje dopiero w modelu
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
            set { image = value; }
			get { return this.image; }
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
        public static string EncodePhoto(string path)
        {
            FileStream fStream = new FileStream(path, FileMode.Open, FileAccess.Read);
            byte[] data = new byte[fStream.Length];
            fStream.Read(data, 0, (int)fStream.Length);
            fStream.Close();

            string hex = BitConverter.ToString(data);
            hex = hex.Replace("-", "");
            return hex;
        }

        private static byte[] ToByteArray(String HexString)
        {
            
            int NumberChars = HexString.Length;

            byte[] bytes = new byte[NumberChars / 2];

            for (int i = 0; i < NumberChars; i += 2)
            {
                bytes[i / 2] = Convert.ToByte(HexString.Substring(i, 2), 16);
            }
            return bytes;
        }

        public static Image DecodePhoto(string hexString)
		{
            byte[] bytes = ToByteArray(hexString);
            MemoryStream ms = new MemoryStream(bytes);
            return Image.FromStream(ms);
		}


        #endregion Methods
    }
}
