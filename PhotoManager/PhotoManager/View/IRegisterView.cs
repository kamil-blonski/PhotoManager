using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoManager
{
    public interface IRegisterView
    {
        event Action<User> CreateAccountEvent;
        string TBName{set;}
        string TBSurname { set; }
        string TBEmail { set; }
        string TBUserName { set; }
        string TBPassword { set; }
        void ShowMessage(bool success, string message);
        void ClearTextBoxes();
    }
}
