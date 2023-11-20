using RudriBooks.DataAccess.Repository.IRepository;
using RudriBooks.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RudriBooks.DataAccess.Repository
{
    public interface ICoverTypeRepository : IRepository<CoverType>
    {
        void Update(CoverType covertype);
    }
}
