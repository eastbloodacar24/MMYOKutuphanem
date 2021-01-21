using Ninject;

namespace MMYOKutuphanem.Worker.DependencyResolvers.Ninject
{
   public class InstanceFactory
    {
        public static T GetInstance<T>()
        {
            var kernel = new StandardKernel(new WorkerModule());
            return kernel.Get<T>();
        }
    }
}
