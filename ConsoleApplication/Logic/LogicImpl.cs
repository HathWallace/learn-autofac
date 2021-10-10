using System.Diagnostics.CodeAnalysis;
using ConsoleApplication.AutoFac;
using ConsoleApplication.Other;
using ConsoleApplication.Service;
using InterfaceLib;

namespace ConsoleApplication.Logic
{
    public class LogicImpl : ILogic
    {
        [Autowired]
        private IService _service { get; set; }

        public void Test()
        {
            _service.Test();
            PublicMethod.WriteLine(GetType());
        }
    }
}