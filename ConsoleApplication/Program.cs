using System;
using System.Reflection;
using Autofac;
using ConsoleApplication.AutoFac;
using ConsoleApplication.Dao;
using ConsoleApplication.Logic;
using ConsoleApplication.Service;

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
                .PropertiesAutowired(new AutowiredPropertySelector())
                .SingleInstance();

            var container = containerBuilder.Build();
            var logic = container.Resolve<ILogic>();
            logic.Test();

            Console.ReadKey();
        }
    }
}
