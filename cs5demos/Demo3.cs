using System;

namespace cs5demos
{
    class Demo3
    {
        public static string Truncate(string value, int length)
        {
            string result = value;
            if (value != null)
            {
                result = value.Substring(0, Math.Min(value.Length, length)).Trim();
            }
            return result;
        }
    }
}
