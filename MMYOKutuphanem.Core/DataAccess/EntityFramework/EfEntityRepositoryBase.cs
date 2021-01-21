using MMYOKutuphanem.Core.Entities;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace MMYOKutuphanem.Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity> where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public TEntity Add(TEntity entity)
        {
            using (TContext DbContext = new TContext())
            {
                var _Eentry = DbContext.Entry(entity);
                _Eentry.State = EntityState.Added;
                DbContext.SaveChanges();
                return _Eentry.Entity;
            }
        }

        public TEntity Modify(TEntity entity)
        {
            using (TContext DbContext = new TContext())
            {
                var _Eentry = DbContext.Entry(entity);
                _Eentry.State = EntityState.Modified;
                DbContext.SaveChanges();
                return _Eentry.Entity;
            }
        }

        public TEntity Get(Func<TEntity, bool> condition = null)
        {
            using (TContext DbContext = new TContext())
            {
                return DbContext.Set<TEntity>().Where(condition).SingleOrDefault();
            }
        }

        public List<TEntity> GetList(Func<TEntity, bool> condition = null)
        {
            using (TContext DbContext = new TContext())
            {
                return condition == null ? DbContext.Set<TEntity>().ToList() : DbContext.Set<TEntity>().Where(condition).ToList();
            }
        }

        public TEntity GetMAX(Func<TEntity, bool> condition = null)
        {
            using (TContext DbContext = new TContext())
            {
                return condition == null ? DbContext.Set<TEntity>().ToList().Last() : DbContext.Set<TEntity>().Where(condition).ToList().Last();
            }
        }

        public int RecordCount(Func<TEntity, bool> condition = null)
        {
            using (TContext DbContext = new TContext())
            {
                return condition == null ? DbContext.Set<TEntity>().ToList().Count : DbContext.Set<TEntity>().Where(condition).ToList().Count;
            }
        }

        TContext _context;
        public List<TEntity> GetDataManagementList()
        {
            if (_context == null)
            {
                _context = new TContext();
            }
            return _context.Set<TEntity>().ToList();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
