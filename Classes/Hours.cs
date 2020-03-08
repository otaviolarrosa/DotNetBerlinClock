using BerlinClock.Classes.Interfaces;
using BerlinClock.Classes.Utils.BerlinClockHelpers;
using System.Text;

namespace BerlinClock.Classes
{
    public class Hours : IHours
    {
        public string CalculateHours(int hours)
        {
            int numberTopHourLamps = hours / 5;
            int numberBottomHourLamps = hours % 5;

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(LampRow.GetLampRow(4, numberTopHourLamps, StatusLampEnum.RED));
            sb.Append(LampRow.GetLampRow(4, numberBottomHourLamps, StatusLampEnum.RED));
            return sb.ToString();
        }
    }
}
