using System;

namespace ConsoleApplication.Other
{
    internal static class PublicMethod
    {
        public static void WriteLine(Type type)
        {
            WriteLine($"You are using {type.Name}.");
        }

        public static void WriteLine(Type usedType, Type type)
        {
            WriteLine($"Use {usedType.Name} in {type.Name}.");
        }

        public static void WriteLine(string line)
        {
            Console.WriteLine(line);
        }

    }
}
