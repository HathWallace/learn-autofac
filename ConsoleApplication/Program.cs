using System;
using Autofac;
using ConsoleApplication.Dao;

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

            var container = containerBuilder.Build();
            var dao = container.Resolve<IDao>();

            dao.Test();

            Console.ReadKey();
        }
    }
}
