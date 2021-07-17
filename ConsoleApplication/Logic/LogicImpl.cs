using ConsoleApplication.AutoFac;
using ConsoleApplication.Other;
using ConsoleApplication.Service;

namespace ConsoleApplication.Logic
{
    public class LogicImpl : ILogic
    {
        [Autowired]
        private IService Service { get; set; }

        public void Test()
        {
            Service.Test();
            PublicMethod.WriteLine(GetType());
        }
    }
}