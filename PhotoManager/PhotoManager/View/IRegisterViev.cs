using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoManager
{
    public interface IRegisterViev
    {
        event Action<User> CreateAccountEvent;
        void ShowMessage(bool success, string message);
    }
}
