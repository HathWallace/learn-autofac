using System.Linq;
using ConsoleApplication.AutoFac;

namespace WindowsFormsApplication
{
    public static class Extensions
    {
        public static object AutoWire(this object obj)
        {
            var autoPropertyList = obj
                .GetType()
                .GetProperties()
                .Where(propertyInfo => propertyInfo.DeclaringType == obj.GetType())
                .Where(propertyInfo => propertyInfo
                    .CustomAttributes
                    .Any(it =>
                        it.AttributeType == typeof(AutowiredAttribute))
                );
            foreach (var propertyInfo in autoPropertyList)
            {
                object instance = AutoFacStartUp
                    .Resolve(propertyInfo.PropertyType);
                propertyInfo.SetValue(obj, instance);
            }
            return obj;
        }
    }
}