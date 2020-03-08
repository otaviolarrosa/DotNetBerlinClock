using BerlinClock.Classes.Interfaces;
using BerlinClock.Classes.Utils.BerlinClockHelpers;
using System.Text;
using BerlinClock.Classes.Utils.ExtensionMethods;
using BerlinClock.Classes.Enums;

namespace BerlinClock.Classes
{
    internal class Minutes : IMinutes
    {
        private const int FIRST_LAMP_OF_TOP_ROW = 1;
        private const int LAST_LAMP_OF_TOP_ROW = 12;
        private const int TOTAL_LAMPS_OF_BOTTOM_ROW = 4;

        public string CalculateMinutes(int minutes)
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(GetTopRow(minutes));
            result.Append(GetBottomRow(minutes));
            return result.ToString();
        }

        private string GetMinuteLampColour(int lampIndex)
        {
            // All lamps multiples of 3 will be RED, to mark the quarters, others will be yellow to simple count the minutes
            return lampIndex % 3 == 0 ? 
                StatusLampEnum.RED.GetDescription() :
                StatusLampEnum.YELLOW.GetDescription();
        }

        private string GetTopRow(int minutes)
        {
            int numberTopMinutesLamps = minutes / 5;
            StringBuilder result = new StringBuilder();
            for (int i = FIRST_LAMP_OF_TOP_ROW; i < LAST_LAMP_OF_TOP_ROW; i++) //for each lamp, make them on or off, and mark the quarters at GetMinuteLampColour
                result.Append(i <= numberTopMinutesLamps ? GetMinuteLampColour(i) : StatusLampEnum.OFF.GetDescription());
            return result.ToString();
        }


        private string GetBottomRow(int minutes)
        {
            int numberBottomMinutesLamps = minutes % 5;
            return LampRow.GetLampRow(TOTAL_LAMPS_OF_BOTTOM_ROW, numberBottomMinutesLamps, StatusLampEnum.YELLOW);
        }
    }
}
