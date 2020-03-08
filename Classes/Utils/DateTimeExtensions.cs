namespace BerlinClock.Classes.Utils
{
    public static class DateTimeExtensions
    {
        public static string GetSeconds(this string aTime)
        {
            return aTime.GetPartOfString(':', 2);
        }

        public static string GetMinutes(this string aTime)
        {
            return aTime.GetPartOfString(':', 1);
        }

        public static string GetHours(this string aTime)
        {
            return aTime.GetPartOfString(':', 0);
        }
    }
}
