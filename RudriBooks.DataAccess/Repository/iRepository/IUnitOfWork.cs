﻿using RudriBooks.DataAccess.Repository.iRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace RudriBooks.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Category { get; }
        ICoverTypeRepository CoverType { get; }

        ISP_Call SP_Call { get; }
        IProductRepository Product { get; }
        void Save();
    }
}