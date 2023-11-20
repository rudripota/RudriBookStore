﻿using RudriBooks.Models;
using RudriBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RudriBooks.DataAccess.Repository
{
    public class CoverTypeRepository : Repository<CoverTypeRepository>, ICoverTypeRepository
    {
        private readonly ApplicationDbContext _db;
        public CoverTypeRepository(ApplicationDbContext db) : base(db)

        {
            _db = db;
        }

        public void Update(CoverType covertype)
        {
            var objFromDb = _db.CoverTypes.FirstOrDefault(s => s.Id == covertype.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = covertype.Name;
            }
        }
}
