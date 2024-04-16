using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using warehouse_management.App.Interfaces;
using warehouse_management.Data;

namespace warehouse_management.App.Services
{
    internal class AuthService : IAuthService
    {
        private readonly WdbContext _context;

        public AuthService(WdbContext context)
        {
            _context = context;
        }
        public bool AuthenticateUser(string username, string password)
        {
            //authenticate user using context and dbset Users from the WdbContext
            var user = _context.Users.FirstOrDefault(u => u.Email == username && u.Password == password);
            if (user != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
