﻿using Microsoft.EntityFrameworkCore;
using MMYOKutuphanem.Core.Entities;
using System.Linq;

namespace MMYOKutuphanem.Core.DataAccess.EntityFramework
{
    public class EfQueryableRepository<T> : IQueryableRepository<T> where T: class, IEntity, new()
    {
        private DbContext _context;
        DbSet<T> _entities;
        public EfQueryableRepository(DbContext context)
        {
            _context = context;
        }
        public IQueryable<T> Table => this.Entities;

        protected virtual DbSet<T> Entities
        {
            get
            {
                if (_entities == null)
                {
                    _entities = _context.Set<T>();
                }
                return _entities;
            }
        }
    }
}
