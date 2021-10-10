using ConsoleApplication.AutoFac;
using ConsoleApplication.Other;
using InterfaceLib;

namespace ConsoleApplication.Logic
{
    public class Logic2Impl : ILogic2
    {
        [Autowired]
        private ILogic1 _logic1 { get; set; }

        public void Test()
        {
            PublicMethod.WriteLine(_logic1.GetType(), GetType());
        }
    }
}