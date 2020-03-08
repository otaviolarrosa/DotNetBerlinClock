using BerlinClock.Classes.Enums;
using BerlinClock.Classes.Interfaces;
using BerlinClock.Classes.Utils.BerlinClockHelpers;
using System.Text;

namespace BerlinClock.Classes
{
    public class Hours : IHours
    {
        private const int TOTAL_LAMPS_PER_LINE = 4;

        public string CalculateHours(int hours)
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(GetTopRow(hours));
            result.Append(GetBottomRow(hours));
            return result.ToString();
        }

        private string GetTopRow(int hours)
        {
            int numberTopHourLampsOn = hours / 5; // get the number of lamps on, on top row
            return LampRow.GetLampRow(TOTAL_LAMPS_PER_LINE, numberTopHourLampsOn, StatusLampEnum.RED);
        }

        private string GetBottomRow(int hours)
        {
            int numberBottomHourLampsOn = hours % 5; // get the number of lamps on, on bottom row
            return LampRow.GetLampRow(TOTAL_LAMPS_PER_LINE, numberBottomHourLampsOn, StatusLampEnum.RED);
        }
    }
}
