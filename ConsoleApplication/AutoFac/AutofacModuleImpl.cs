using Autofac;

namespace ConsoleApplication.AutoFac
{
    public class AutofacModuleImpl : AutofacModule
    {
        public void StartUp()
        {
            var containerBuilder = new ContainerBuilder();
            base.Load(containerBuilder);
        }
    }
}