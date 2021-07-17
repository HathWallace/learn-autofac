using System;

namespace ConsoleApplication.Other
{
    internal static class PublicMethod
    {
        public static void WriteLine(Type type)
        {
            Console.WriteLine($"You are using {type.Name}.");
        }
    }
}
