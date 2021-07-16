using ConsoleApplication.Dao;

namespace ConsoleApplication.Service
{
    public class ServiceImpl : IService
    {
        private IDao Dao { get; set; }

        public void Test()
        {
            Dao.Test();
            PublicMethod.WriteLine(GetType());
        }
    }
}