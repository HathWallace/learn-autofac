using System;

namespace ConsoleApplication.AutoFac
{
    [AttributeUsage(AttributeTargets.Property)]
    public class AutowiredAttribute : Attribute
    {
    }
}