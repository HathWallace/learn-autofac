using ConsoleApplication.AutoFac;
using ConsoleApplication.Dao;
using ConsoleApplication.Other;

namespace ConsoleApplication.Service
{
    public class ServiceImpl : IService
    {
        [Autowired]
        private IDao Dao { get; set; }

        public void Test()
        {
            Dao.Test();
            PublicMethod.WriteLine(GetType());
        }
    }
}