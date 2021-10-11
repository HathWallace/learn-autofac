using System;
using Autofac;

namespace ConsoleApplication.AutoFac
{
    public static class AutoFacStartUp
    {
        private static readonly ContainerBuilder _builder;
        private static readonly IContainer _container;

        static AutoFacStartUp()
        {
            _builder = new ContainerBuilder();

            var assemblies = AppDomain
                .CurrentDomain
                .GetAssemblies();
            _builder
                .RegisterAssemblyTypes(assemblies)
                .AsImplementedInterfaces()
                .AsSelf()
                .PropertiesAutowired(new AutowiredPropertySelector(), true);
            _container = _builder.Build();
        }

        public static T Resolve<T>()
        {
            return _container.Resolve<T>();
        }
    }
}