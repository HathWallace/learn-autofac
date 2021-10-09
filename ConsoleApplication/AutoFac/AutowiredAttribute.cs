using System;
using System.Diagnostics.CodeAnalysis;

namespace ConsoleApplication.AutoFac
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class AutowiredAttribute : Attribute
    {
    }
}