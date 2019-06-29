using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoManager.Model
{
	public class Album
	{
		
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

		public Album(string name, string desc, DateTime dt)
		{
			photos = new List<Photo>();
			owners = new List<User>();
			this.name = name;
			this.description = desc;
			this.creationDate = dt;
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
