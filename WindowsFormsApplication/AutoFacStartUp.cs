using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Autofac;
using ConsoleApplication.AutoFac;
using TestClassLibrary;

namespace WindowsFormsApplication
{
    public static class AutoFacStartUp
    {
        private static readonly IContainer _container;

        static AutoFacStartUp()
        {
            var builder = new ContainerBuilder();

            var test = Assembly
                .GetExecutingAssembly()
                .GetReferencedAssemblies()
                .Where(an => an.GetPublicKeyToken().Length == 0)
                .ToArray();

            var assemblies = AppDomain
                .CurrentDomain
                .GetAssemblies();
            builder
                .RegisterAssemblyTypes(assemblies)
                .AsImplementedInterfaces()
                .AsSelf()
                .PropertiesAutowired(new AutowiredPropertySelector(), true);
            _container = builder.Build();
        }

        public static T Resolve<T>()
        {
            return _container.Resolve<T>();
        }

        public static object Resolve(Type type)
        {
            return _container.Resolve(type);
        }
    }
}