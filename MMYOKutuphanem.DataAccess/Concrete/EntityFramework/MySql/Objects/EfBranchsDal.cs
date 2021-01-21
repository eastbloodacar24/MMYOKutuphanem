using MMYOKutuphanem.Core.DataAccess.EntityFramework;
using MMYOKutuphanem.DataAccess.Absract;
using MMYOKutuphanem.DataAccess.Concrete.EntityFramework.MySql.Context;
using MMYOKutuphanem.Entites.Concrete;
using System.Linq;

namespace MMYOKutuphanem.DataAccess.Concrete.EntityFramework.MySql.Objects
{
    public class EfBranchsDal : EfEntityRepositoryBase<Branch, MySqlContext>, IBranchDal
    {
        public string[] GetNames()
        {
            using (MySqlContext DbContext = new MySqlContext())
            {
                return DbContext.Set<Branch>().ToList().Select(p => p.Name).ToArray<string>();
            }
        }
    }
}
