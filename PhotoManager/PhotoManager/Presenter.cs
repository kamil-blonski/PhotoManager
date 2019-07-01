using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhotoManager.Model;
namespace PhotoManager
{
	class Presenter
	{
		IView view;
		Model.Model model;
		public Presenter(IView view, Model.Model model)
		{
			this.view = view;
			this.model = model;
			this.view.LoggingEvent += LoggingEvent;
            this.view.IVievRegister.CreateAccountEvent += CreateAccountEvent;
            this.view.IVievForm.AddPhotoEvent += AddPhotoEvent;
            this.view.IVievForm.IAddAlbumView.AddAlbumEvent += AddAlbumEvent;
			this.view.IVievForm.GetAlbums += GetAlbums;
		}

		private List<Album> GetAlbums()
		{
			return model.GetAlbums();
		}

        private void LoggingEvent(User user)
        {

            try
            {
                if (model.checkPassword(user) == false)
                {
                    view.ShowMessage(false, "Incorrect login or password.");
                }
                //else
                //{
                //    view.TBUserName = string.Empty;
                //    view.TBPassword = string.Empty;
                //    Form1.InstanceForm1.ShowDialog();
                //}

            }
            catch (Exception exc)
            {
                view.ShowMessage(false, exc.Message);
            }
        }

        private void CreateAccountEvent(User user)
        {
            if (model.UserExists(user))
            {
                view.IVievRegister.ShowMessage(false, "A user with the same login already exists.");
                return;
            }
            if(model.EmailExists(user))
            {
                view.IVievRegister.ShowMessage(false, "An account with the same e-mail address already exists.");
                return;
            }
            if (model.CreateAccount(user))
            {
                view.IVievRegister.TBName = string.Empty;
                view.IVievRegister.TBSurname = string.Empty;
                view.IVievRegister.TBEmail = string.Empty;
                view.IVievRegister.TBUserName = string.Empty;
                view.IVievRegister.TBPassword = string.Empty;
                view.IVievRegister.ShowMessage(true, "An account was created sucessfully.");
                
            }
            else
                view.IVievRegister.ShowMessage(false, "Account creation failed. Try one more time.");
        }

        private void AddPhotoEvent(string imgPath, Photo photo)
        {
            model.AddPhoto(imgPath, photo);
        }

        private void AddAlbumEvent(Album album)
        {
            if (model.AddAlbum(album))
                view.IVievForm.IAddAlbumView.ShowMessage(true, "Album created successfully.");
            else
                view.IVievForm.IAddAlbumView.ShowMessage(false, "Error during creating an album.");
        }
	}
}
