using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoManager.Model
{
	class Model
	{
		public Model()
		{

		}

		public bool checkPassword(string formPassword, string dbPassword)
		{
			if (formPassword == dbPassword)
			{
				new Form1().ShowDialog();
				return true;
			}
			else
				return false;
		}
	}
}
