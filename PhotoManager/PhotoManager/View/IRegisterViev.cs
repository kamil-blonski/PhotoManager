using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoManager
{
    public interface IRegisterViev
    {
        string NameR { get; set; }
        string Surname { get; set; }
        string UserName { get; set; }
        string Password { get; set; }
        string Email { get; set; }
        event Action <int?, string, string ,string ,string ,string > CreateAccountEvent;
    }
}
