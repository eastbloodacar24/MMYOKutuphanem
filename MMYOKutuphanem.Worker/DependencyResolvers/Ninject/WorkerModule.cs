using MMYOKutuphanem.DataAccess.Absract;
using MMYOKutuphanem.DataAccess.Concrete.EntityFramework.SQLite.Objects;
using MMYOKutuphanem.Worker.Abstract;
using MMYOKutuphanem.Worker.Contrete.Managers;
using Ninject.Modules;
namespace MMYOKutuphanem.Worker.DependencyResolvers.Ninject
{
    public class WorkerModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IUserDal>().To<EfUsersDal>().InSingletonScope();
            Bind<IBranchDal>().To<EfBranchsDal>().InSingletonScope();
            Bind<IAssigmentDal>().To<EfAssigmentsDal>().InSingletonScope();
            Bind<IBookDal>().To<EfBooksDal>().InSingletonScope();

            Bind<IUserService>().To<UserManager>().InSingletonScope();
            Bind<IBranchService>().To<BranchManager>().InSingletonScope();
            Bind<IAssignmentService>().To<AssigmentManager>().InSingletonScope();
            Bind<IBookService>().To<BookManager>().InSingletonScope();
        }
    }
}
