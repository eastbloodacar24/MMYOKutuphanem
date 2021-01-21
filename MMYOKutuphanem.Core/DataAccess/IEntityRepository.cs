using MMYOKutuphanem.Core.Entities;
using System.Collections.Generic;
using System;
namespace MMYOKutuphanem.Core.DataAccess
{
    public interface IEntityRepository<T> where T: class, IEntity, new()
    {
        List<T> GetList(Func<T, bool> condition = null);
        T Get(Func<T, bool> condition = null);
        T Add(T entity);
        T Modify(T entity);
        int RecordCount(Func<T, bool> condition = null);
        T GetMAX(Func<T, bool> condition = null);
        List<T> GetDataManagementList();
        void SaveChanges();
    }
}
