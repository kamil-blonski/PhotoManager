using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoManager
{
	public interface IView
	{
        event Action<string, string> LoggingEvent;
		//event Action<string,string> LoggingEvent;
        string TBUserName { set; }
        string TBPassword { set; }
		void ShowMessage(bool success, string message);
        IRegisterView IVievRegister { get; }
        IForm1View IVievForm { get; }
	}
}
