using ConsoleApplication.AutoFac;
using ConsoleApplication.Dao;
using ConsoleApplication.Other;
using InterfaceLib;

namespace ConsoleApplication.Service
{
    public class ServiceImpl : IService
    {
        [Autowired]
        private IDao _dao { get; set; }

        public void Test()
        {
            _dao.Test();
            PublicMethod.WriteLine(GetType());
        }
    }
}