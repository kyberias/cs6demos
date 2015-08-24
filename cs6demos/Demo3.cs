using System;

namespace cs6demos
{
    // Null-Conditional Operator
    class Demo3
    {
        public static string Truncate(string value, int length)
        {
            return value?.Substring(0, Math.Min(value.Length, length)).Trim();
        }
    }
}
