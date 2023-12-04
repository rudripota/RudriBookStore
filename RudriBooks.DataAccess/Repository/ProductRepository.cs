﻿using RudriBooks.DataAccess.Repository.iRepository;

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
        private readonly ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) : base(db)

        {
            _db = db;
        }

        public void Update(Product product)
        {
            var objFromDb = _db.Products.FirstOrDefault(s => s.Id == product.Id);
            if (objFromDb != null)
            {
                if (product.ImageUrl != null)
                {
                    objFromDb.Title = product.Title;
                    objFromDb.Description = product.Description;
                    objFromDb.ISBN = product.ISBN;
                    objFromDb.Author = product.Author;
                    objFromDb.ListPrice = product.ListPrice;
                    objFromDb.CategoryId = product.CategoryId;
                    objFromDb.CoverTypeId = product.CoverTypeId;
                }
            }
        }
    }
}
