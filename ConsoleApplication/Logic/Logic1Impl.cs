using ConsoleApplication.AutoFac;
using ConsoleApplication.Other;
using InterfaceLib;

namespace ConsoleApplication.Logic
{
    public class Logic1Impl : ILogic1
    {
        [Autowired]
        private ILogic2 _logic2 { get; set; }

        public void Test()
        {
            PublicMethod.WriteLine(_logic2.GetType(), GetType());
        }
    }
}