using Autofac;

namespace ConsoleApplication.AutoFac
{
    public class Startup
    {
        public void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterModule(new AutofacModule());
        }
    }
}