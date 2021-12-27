using System;
using System.Reflection;
using Autofac;
using Autofac.Core;
using ConsoleApplication.AutoFac;
using ConsoleApplication.Dao;
using ConsoleApplication.Logic;
using ConsoleApplication.Service;
using InterfaceLib;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var containerBuilder = new ContainerBuilder();
            var executingAssembly = Assembly.GetExecutingAssembly();
            containerBuilder
                .RegisterAssemblyTypes(executingAssembly)
                .AsImplementedInterfaces()
                .PropertiesAutowired(new AutowiredPropertySelector(), true);

            var container = containerBuilder.Build();

            var logic = container.Resolve<ILogic>();
            logic.Test();

            var logic1 = container.Resolve<ILogic1>();
            var logic2 = container.Resolve<ILogic2>();
            logic1.Test();
            logic2.Test();

            Console.ReadKey();
        }
    }
}
