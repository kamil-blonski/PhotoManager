using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoManager
{
    interface IRegisterViev
    {
        string Name { get; set; }
        string Surname { get; set; }
        string UserName { get; set; }
        string Password { get; set; }
        string Email { get; set; }
        
    }
}
