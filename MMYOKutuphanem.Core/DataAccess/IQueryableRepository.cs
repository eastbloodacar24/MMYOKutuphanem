using MMYOKutuphanem.Core.Entities;
using System.Linq;

namespace MMYOKutuphanem.Core.DataAccess
{
    public interface IQueryableRepository<T> where T: class, IEntity, new()
    {
        IQueryable<T> Table { get; }
    }
}
