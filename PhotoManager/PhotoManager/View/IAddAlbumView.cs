using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
