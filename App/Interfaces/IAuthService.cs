using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace warehouse_management.App.Interfaces
{
    public interface IAuthService
    {
        bool AuthenticateUser(string username, string password);
    }
}
