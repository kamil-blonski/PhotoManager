using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhotoManager.Model;
namespace PhotoManager
{
	public class User
	{
		private object id = null;
		private string name;
		private string surname;
		private string login;
		private string password;
		private string email;
		private List<Album> albums;


		public User()
		{

		}

		public User(object id, string name, string surname,
			string login, string password, string email)
		{
			this.id = id;
			this.name = name;
			this.surname = surname;
			this.login = login;
			this.password = password;
			this.email = email;
			this.albums = new List<Model.Album>();
		}

		public string Name
		{
			get { return name; }
			set { this.name = value; }
		}

		public string Surname
		{
			get { return surname; }
			set { this.surname = value; }
		}

		public string Email
		{
			get { return email; }
			set { this.email = value; }
		}

		public string Password
		{
			get { return password; }
			set { this.password = value; }
		}

		public string Login
		{
			get { return login; }
			set { this.login = value; }
		}

		public void addAlbum(Model.Album album)
		{
			albums.Add(album);
		}


	}
}
