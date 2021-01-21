using MMYOKutuphanem.Core.DataAccess;
using MMYOKutuphanem.Entites.Concrete;

namespace MMYOKutuphanem.DataAccess.Absract
{
    public interface IBranchDal : IEntityRepository<Branch>
    {
        string[] GetNames();
    }
}
