using Microsoft.EntityFrameworkCore;
using MMYOKutuphanem.Core.DataAccess.EntityFramework;
using MMYOKutuphanem.DataAccess.Absract;
using MMYOKutuphanem.DataAccess.Concrete.EntityFramework.MySql.Context;
using MMYOKutuphanem.Entites.Concrete;

namespace MMYOKutuphanem.DataAccess.Concrete.EntityFramework.MySql.Objects
{
    public class EfAssigmentsDal : EfEntityRepositoryBase<Assignment, MySqlContext>, IAssigmentDal
    {

      
    }
}
