using System;

namespace BerlinClock.Classes.Utils.ExtensionMethods
{
    internal static class StringExtensions
    {
        internal static string GetPartOfString(this string str, char separator, int index)
        {
            return str.Split(separator)[index];
        }

        internal static int ToInt32(this string str)
        {
            return Convert.ToInt32(str);
        }
    }
}
