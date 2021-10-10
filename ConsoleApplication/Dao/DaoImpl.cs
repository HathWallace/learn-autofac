using ConsoleApplication.Other;
using InterfaceLib;

namespace ConsoleApplication.Dao
{
    public class DaoImpl : IDao
    {
        public void Test()
        {
            PublicMethod.WriteLine(GetType());
        }
    }
}