using System;

namespace BerlinClock.Classes.Utils
{
    public static class StringExtensions
    {
        public static string GetPartOfString(this string str, char separator, int index)
        {
            return str.Split(separator)[index];
        }

        public static int ToInt32(this string str)
        {
            return Convert.ToInt32(str);
        }
    }
}
