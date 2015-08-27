using System;

namespace cs5demos
{
    class Demo3
    {
        public static string Truncate(string value, int length)
        {
            if (value != null)
            {
                return value.Substring(0, Math.Min(value.Length, length)).Trim();
            }
            return value;
        }
    }
}
