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
        void ShowMessage(bool success, string message);
	}
}
