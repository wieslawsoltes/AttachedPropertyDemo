using System.Collections.Generic;

namespace AttachedPropertyDemo
{
    public class Demo
    {
        private static readonly Dictionary<object, object?> s_values = new();

        public static object? GeTest(object? obj)
        {
            if (obj is not null && s_values.TryGetValue(obj, out var value))
            {
                return value;
            }
            return null;
        }

        public static void SetTest(object? obj, object? value)
        {
            if (obj != null)
            {
                s_values[obj] = value;
            }
        }
    }
}