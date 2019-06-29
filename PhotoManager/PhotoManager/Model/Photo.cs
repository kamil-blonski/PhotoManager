using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

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
			// hex
		}
	}

	

}
