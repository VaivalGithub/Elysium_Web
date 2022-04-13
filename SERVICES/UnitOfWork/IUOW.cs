using SERVICES.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SERVICES.UnitOfWork
{
    public interface IUOW
    {
        IUser Users { get; }
        IAccount Account { get; }
        void Save();
    }
}
