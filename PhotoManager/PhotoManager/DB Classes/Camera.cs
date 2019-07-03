using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoManager.Model
{
	public class Camera
	{
		string type;
		User owner;

		public Camera(string type, User owner)
		{
			this.type = type;
			this.owner = owner;
		}
	}
}
