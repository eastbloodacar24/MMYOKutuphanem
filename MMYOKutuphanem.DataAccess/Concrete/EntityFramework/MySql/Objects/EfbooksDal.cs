using System;
using System.Linq;
using MMYOKutuphanem.Core.DataAccess.EntityFramework;
using MMYOKutuphanem.DataAccess.Absract;
using MMYOKutuphanem.DataAccess.Concrete.EntityFramework.MySql.Context;
using MMYOKutuphanem.Entites.Concrete;

namespace MMYOKutuphanem.DataAccess.Concrete.EntityFramework.MySql.Objects
{
    public class EfBooksDal : EfEntityRepositoryBase<Book, MySqlContext>, IBookDal
    {
        public string[] GetNames(Func<Book, bool> condition = null)
        {
            using (MySqlContext DbContext = new MySqlContext())
            {
                return condition == null ? DbContext.Set<Book>().ToList().Select(p => p.Name).ToArray<string>() : DbContext.Set<Book>().ToList().Where(condition).Select(p => p.Name).ToArray<string>();
            }
        }

        public long[] GetBarcodCodes(Func<Book, bool> condition = null)
        {
            using (MySqlContext DbContext = new MySqlContext())
            {
                return condition == null ? DbContext.Set<Book>().ToList().Select(p => p.Barcod).ToArray<long>() : DbContext.Set<Book>().ToList().Where(condition).Select(p => p.Barcod).ToArray<long>();
            }
        }
    }
}
