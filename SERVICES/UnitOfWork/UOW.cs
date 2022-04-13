using Microsoft.Extensions.Configuration;
using SERVICES.Service.Implementations;
using SERVICES.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SERVICES.UnitOfWork
{
    public class UOW : IUOW
    {
        private IConfiguration _Configuration;

        private IUser _user;
        private IAccount _account;
        public UOW(IConfiguration _configuration)
        {
            _Configuration = _configuration;
        }

        public IUser Users
        {
            get
            {
                if (_user == null)
                {
                    _user = new UserService(_Configuration);
                }

                return _user;
            }
        }

        public IAccount Account
        {
            get
            {
                if (_account == null)
                {
                    _account = new AccountService(_Configuration);
                }

                return _account;
            }
        }

        public void Save()
        {
            // _context.SaveChanges();
        }
    }
}
