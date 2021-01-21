using System;
using System.Linq;
using System.Windows.Forms;
using MMYOKutuphanem.Core.DataAccess.EntityFramework;
using MMYOKutuphanem.DataAccess.Absract;
using MMYOKutuphanem.Entites.Concrete;

namespace MMYOKutuphanem.DataAccess.Concrete.EntityFramework.SQLite.Objects
{
    public class EfUsersDal : EfEntityRepositoryBase<User, SQLiteContext>, IUserDal
    {
        public string[] GetNames(Func<User, bool> condition = null)
        {
            using (SQLiteContext DbContext = new SQLiteContext())
            {
                return condition == null ? DbContext.Set<User>().ToList().Select(p => p.Name).ToArray<string>() : DbContext.Set<User>().ToList().Where(condition).Select(p => p.Name).ToArray<string>();
            }
        }
    }
}
