using BerlinClock.Classes;
using BerlinClock.Classes.Interfaces;
using BerlinClock.Classes.Utils.ExtensionMethods;
using BerlinClock.Interfaces;
using System.Text;

namespace BerlinClock
{
    public class TimeConverter : ITimeConverter
    {
        private ISeconds _seconds;
        private IMinutes _minutes;
        private IHours _hours;

        public TimeConverter()
        {
            _seconds = new Seconds();
            _minutes = new Minutes();
            _hours = new Hours();
        }


        public string convertTime(string aTime)
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(_seconds.CalculateSeconds(aTime.GetSeconds().ToInt32()));
            result.AppendLine(_hours.CalculateHours(aTime.GetHours().ToInt32()));
            result.Append(_minutes.CalculateMinutes(aTime.GetMinutes().ToInt32()));

            return result.ToString();
        }
    }
}
