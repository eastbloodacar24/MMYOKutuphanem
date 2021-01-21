using MMYOKutuphanem.Core.DataAccess;
using MMYOKutuphanem.Entites.Concrete;
using System;
namespace MMYOKutuphanem.DataAccess.Absract
{
    public interface IUserDal : IEntityRepository<User>
    {
        string[] GetNames(Func<User, bool> condition = null);
    }
}
