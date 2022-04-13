using CORE.Models;
using SHARED;
using System;
using System.Collections.Generic;
using System.Text;

namespace SERVICES.Service.Interfaces
{
    public interface IAccount
    {

        ServiceResponse<Account> AdminAuth(Account account);

    }
}
