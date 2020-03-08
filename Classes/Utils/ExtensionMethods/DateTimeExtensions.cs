namespace BerlinClock.Classes.Utils.ExtensionMethods
{
    internal static class DateTimeExtensions
    {
        internal static string GetSeconds(this string aTime)
        {
            return aTime.GetPartOfString(':', 2);
        }

        internal static string GetMinutes(this string aTime)
        {
            return aTime.GetPartOfString(':', 1);
        }

        internal static string GetHours(this string aTime)
        {
            return aTime.GetPartOfString(':', 0);
        }
    }
}
