using System;
using System.Collections.Generic;
using System.Text;

namespace RudriBooks.DataAccess.Repository.iRepository
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Category { get; }

        ISP_Call SP_Call { get; }

        void Save();
    }
}