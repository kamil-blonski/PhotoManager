using System;
using PhotoManager.Model;

namespace PhotoManager
{
    public interface IAddAlbumView
	{
        event Action<Album> AddAlbumEvent;
        event Action RefreshAlbumListInForm1Event;
        void ShowMessage(bool success, string message);
        void ClearTextBoxes();
	}
}
