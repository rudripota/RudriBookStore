using RudriBooks.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RudriBooks.DataAccess.Repository.iRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category category);
    }
}
