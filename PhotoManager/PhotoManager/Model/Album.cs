using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoManager.Model
{
	public class Album
	{
		private int id;
		private List<Photo> photos;
		private List<User> owners;
		private string name;
		private string description;
		private DateTime creationDate;
		private enum type
		{
			PE,
			PC
		}

		public Album()
		{
			photos = new List<Photo>();
			owners = new List<User>();
		}

		public void addPhoto(Photo photo)
		{
			this.photos.Add(photo);
		}

		public void deletePhoto(Photo photo)
		{
			this.photos.Remove(photo);
		}

	}
}
