using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceLib;

namespace TestClassLibrary
{
    public class TestImpl : ITest
    {
        public void Test()
        {
            Console.WriteLine("Hello, world!");
        }
    }
}
