using MMYOKutuphanem.Core.DataAccess.EntityFramework;
using MMYOKutuphanem.DataAccess.Absract;
using MMYOKutuphanem.DataAccess.Concrete.EntityFramework.MySql.Context;
using MMYOKutuphanem.Entites.Concrete;
using System;
using System.Linq;

namespace MMYOKutuphanem.DataAccess.Concrete.EntityFramework.MySql.Objects
{
    public class EfUsersDal : EfEntityRepositoryBase<User, MySqlContext>, IUserDal
    {
        public string[] GetNames(Func<User, bool> condition = null)
        {
            using (MySqlContext DbContext = new MySqlContext())
            {
                return condition == null ? DbContext.Set<User>().ToList().Select(p => p.Name).ToArray<string>() : DbContext.Set<User>().ToList().Where(condition).Select(p => p.Name).ToArray<string>();
            }
        }
    }
}
