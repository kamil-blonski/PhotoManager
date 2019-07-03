using System;
using System.Collections.Generic;

namespace PhotoManager.Model
{
    public class Album
	{
		#region Fields
		private List<Photo> photos;
        private int? id;
        private string name;
		private string description;
        private string selectedType;
		private DateTime creationDate;
        #endregion Fields

        #region Constructors
        public Album(int? id, string name, DateTime currentDate, string description, string selectedType)
        {
            this.id = id;
            this.name = name;
            this.selectedType = selectedType;
            this.description = description;
            this.creationDate = currentDate;
            photos = new List<Photo>();
        }
        #endregion Constructors

        #region Properties
        public int? ID
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
                if (selectedType == "PE")
                    return "PE";
                else
                    return "PC";
            }
        }

        public List<Photo> PhotoList
        {
            set { photos = value; }
            get { return photos; }
        }

        public DateTime CreationDate
        {
            get { return creationDate; }
        }
		#endregion Properties

		#region Methods
		public void addPhoto(Photo photo)
        {
            photos.Add(photo);
        }
		#endregion Methods
	}
}
