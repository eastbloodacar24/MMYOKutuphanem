using MMYOKutuphanem.Core.DataAccess.EntityFramework;
using MMYOKutuphanem.DataAccess.Absract;
using MMYOKutuphanem.Entites.Concrete;

namespace MMYOKutuphanem.DataAccess.Concrete.EntityFramework.SQLite.Objects
{
    public class EfAssigmentsDal : EfEntityRepositoryBase<Assignment, SQLiteContext>, IAssigmentDal
    {

    }
}
