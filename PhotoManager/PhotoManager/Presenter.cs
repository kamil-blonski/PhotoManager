using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            this.view.IVievRegister.CreateAccountEvent += CreateAccount;


		}


		private void LoggingEvent(string formPassword, string dbPassword)
		{
			try
			{
				if (model.checkPassword(formPassword, dbPassword) == false)
				{
					view.ShowMessage(false, "Incorrect password");
				}
			}
			catch (Exception exc)
			{
				view.ShowMessage(false, exc.Message);
			}

		}

		
		private void CreateAccount(int? id, string name, string surname, string password, string email, string login)
        {
            Console.WriteLine(this.view.IVievRegister.Email);
        }

	}
}
