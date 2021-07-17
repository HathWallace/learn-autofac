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
                .RegisterType<LogicImpl>()
                .PropertiesAutowired(new AutowiredPropertySelector())
                .As<ILogic>();
            containerBuilder
                .RegisterType<NewLogicImpl>()
                .PropertiesAutowired(new AutowiredPropertySelector())
                .Keyed<ILogic>(LogicType.LOGIC2)
                .PreserveExistingDefaults();

            var container = containerBuilder.Build();
            var logic = container.Resolve<ILogic>();
            Console.WriteLine("logic:");
            logic.Test();

            var logic2 = container.ResolveKeyed<ILogic>(LogicType.LOGIC2);
            Console.WriteLine("logic2:");
            logic2.Test();

            Console.ReadKey();
        }

        public enum LogicType
        {
            LOGIC_DEFAULT,

            LOGIC2,
        }
    }
}
