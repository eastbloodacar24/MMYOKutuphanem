using System;
using MMYOKutuphanem.Core.DataAccess;
using MMYOKutuphanem.Entites.Concrete;

namespace MMYOKutuphanem.DataAccess.Absract
{
    public interface IBookDal : IEntityRepository<Book>
    {
        string[] GetNames(Func<Book, bool> condition = null);
        long[] GetBarcodCodes(Func<Book, bool> condition = null);
    }
}
