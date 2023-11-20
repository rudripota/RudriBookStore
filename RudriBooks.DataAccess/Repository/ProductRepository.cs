using RudriBooks.DataAccess.Repository.iRepository;

using RudriBooks.Models;
using RudriBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RudriBooks.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
    }
}
