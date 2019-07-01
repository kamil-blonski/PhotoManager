using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoManager.Model
{
	public class Album
	{
        #region Fields
        private List<Photo> photos;
		private List<User> owners;
        private int id;
        private string name;
		private string description;
        private string selectedType;
		private DateTime creationDate;
		private enum type
		{
			PE,
			PC
		}
        #endregion Fields

        #region Constructors
        public Album()
        {

        }

		public Album(string name)
		{
			this.name = name;
		}

        public Album(string name, string selectedType, string description, DateTime currentDate)
        {
            this.name = name;
            this.selectedType = selectedType;
            this.description = description;
            this.creationDate = currentDate;
        }
		public Album(string name, string desc, DateTime dt)
		{
			photos = new List<Photo>();
			owners = new List<User>();
			this.name = name;
			this.description = desc;
			this.creationDate = dt;
		}
        #endregion Constructors

        #region Properties
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
        }
        public string Description
        {
            get { return description; }
        }

        public string SelectedType
        {
            get
            {
                if (selectedType == "Private")
                    return "PE";
                else
                    return "PC";
            }
        }

        public DateTime CreationDate
        {
            get { return creationDate; }
        }
        #endregion Properties

        #region Methods
        public void addPhoto(Photo photo)
		{
			this.photos.Add(photo);
		}

		public void deletePhoto(Photo photo)
		{
			this.photos.Remove(photo);
		}
        #endregion Methods
    }
}
