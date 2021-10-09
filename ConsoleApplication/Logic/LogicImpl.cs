using System.Diagnostics.CodeAnalysis;
using ConsoleApplication.AutoFac;
using ConsoleApplication.Other;
using ConsoleApplication.Service;

namespace ConsoleApplication.Logic
{
    public class LogicImpl : ILogic
    {
        [Autowired]
        private IService Service { get; set; }

        [Autowired]
        private IService _service;

        public void Test()
        {
            //Service.Test();
            _service.Test();
            PublicMethod.WriteLine(GetType());
        }
    }
}