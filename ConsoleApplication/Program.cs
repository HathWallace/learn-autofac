using System;
using Autofac;
using ConsoleApplication.AutoFac;
using ConsoleApplication.Logic;

namespace ConsoleApplication
{
    class Program
    {
        [Autowired]
        private static ILogic Logic { get; set; }

        static void Main(string[] args)
        {
            var autofacModuleImpl = new AutofacModuleImpl();
            autofacModuleImpl.StartUp();

            Logic.Test();
            Console.ReadKey();
        }
    }
}
