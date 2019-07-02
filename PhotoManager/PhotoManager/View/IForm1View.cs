using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhotoManager.Model;

namespace PhotoManager
{
	public interface IForm1View
	{
        event Action<string, Photo, Album> AddPhotoEvent;
		event Func<List<Album>> GetAlbums;
        //event Action<Album> RefreshAlbumList;
		IAddAlbumView IAddAlbumView { get; }
        void AddNewAlbumToList(Album album);
        void ShowMessage(bool success, string message);
    }
}
