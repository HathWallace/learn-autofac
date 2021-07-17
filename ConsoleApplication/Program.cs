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
            containerBuilder
                .RegisterType<DaoImpl>()
                .As<IDao>();
            containerBuilder
                .RegisterType<ServiceImpl>()
                .PropertiesAutowired(new AutowiredPropertySelector())
                .As<IService>();
            containerBuilder
                .RegisterType<LogicImpl>()
                .PropertiesAutowired(new AutowiredPropertySelector())
                .As<ILogic>();

            var container = containerBuilder.Build();
            var dao = container.Resolve<ILogic>();

            dao.Test();

            Console.ReadKey();
        }
    }
}
