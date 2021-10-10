using System;
using ConsoleApplication.Other;
using InterfaceLib;

namespace ConsoleApplication.Logic
{
    public class ValueLogicImpl : IValueLogic
    {
        private readonly string _value;

        public ValueLogicImpl(string value)
        {
            _value = value;
        }

        public void Test()
        {
            PublicMethod.WriteLine(GetType());
            PublicMethod.WriteLine($"My value is {_value}.");
        }
    }
}