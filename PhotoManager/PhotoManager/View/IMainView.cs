using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhotoManager.Model;

namespace PhotoManager
{
	public interface IMainViev
	{
        event Action<string, Photo> AddPhotoEvent;
		event Func<List<Album>> GetAlbums;
        event Action<Album> GetPhotosFromDB;
        event Action<string> SaveAlbum;
        event Action GetUserName;
		IAddAlbumView IAddAlbumView { get; }
        List<Photo> PhotoList { set; }
        string UserName { set; }
        void AddNewAlbumToList(Album album);
        void AddNewPhotoToList(Photo newPhotos);
        void ShowMessage(bool success, string message);
    }
}
