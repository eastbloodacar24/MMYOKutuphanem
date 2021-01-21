using MMYOKutuphanem.Core.DataAccess.EntityFramework;
using MMYOKutuphanem.DataAccess.Absract;
using MMYOKutuphanem.Entites.Concrete;
using System.Linq;

namespace MMYOKutuphanem.DataAccess.Concrete.EntityFramework.SQLite.Objects
{
    public class EfBranchsDal : EfEntityRepositoryBase<Branch, SQLiteContext>, IBranchDal
    {
        public string[] GetNames()
        {
            using (SQLiteContext DbContext = new SQLiteContext())
            {
                return DbContext.Set<Branch>().ToList().Select(p => p.Name).ToArray<string>();
            }
        }
    }
}
