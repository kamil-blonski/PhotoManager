using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Media.Imaging;
/*
 https://docs.microsoft.com/en-us/dotnet/framework/wpf/graphics-multimedia/how-to-encode-and-decode-a-jpeg-image
*/

namespace PhotoManager.Model
{
	public class Photo
	{
		private int id;
		private string name;
		private DateTime creationDate;
		private string description;
		private ImageFormat format;
		private Size photoSize;
		//private string path;


		public Photo(int id, string name, DateTime creationDate,
			string description, ImageFormat format, Size photoSize)
		{
			this.id = id;
			this.name = name;
			this.description = description;
			this.format = format;
			this.photoSize = photoSize;
			this.creationDate = creationDate;
		}


		public void EncodePhoto()
		{
			
		}

		public void DecodePhoto()
		{

		}
	}
}
