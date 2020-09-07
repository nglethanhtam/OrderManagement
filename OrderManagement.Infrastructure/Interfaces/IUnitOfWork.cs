using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement.Infrastructure.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        bool Commit();
    }
}
