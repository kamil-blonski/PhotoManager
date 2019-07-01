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
        #region Fields
        private int id_;
        private object id = null;
		private string name;
		private string surname;
		private string login;
		private string password;
		private string email;
		private List<Album> albums;
        #endregion Fields

        #region Constructors
        public User()
		{

		}
        public User(string login, string password)
        {
            this.login = login;
            this.password = password;
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

        #endregion Constructors

        #region Properties
        public int ID
        {
            get { return id_; }
            set { this.id_ = value; }
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
        #endregion Properties

        #region Methods
        public void addAlbum(Model.Album album)
		{
			albums.Add(album);
		}

        #endregion Methods
    }
}
