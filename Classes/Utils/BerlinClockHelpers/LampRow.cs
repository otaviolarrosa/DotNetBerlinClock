using BerlinClock.Classes.Utils.ExtensionMethods;
using System.Net.NetworkInformation;
using System.Text;

namespace BerlinClock.Classes.Utils.BerlinClockHelpers
{
    internal static class LampRow
    {
        internal static string GetLampRow(int totalNumberLamps, int numberLampsOn, StatusLampEnum statusLamp)
        {
            StringBuilder result = new StringBuilder();
            result.Append(AddLampsOn(numberLampsOn, statusLamp));
            result.Append(AddLampsOff(numberLampsOn, totalNumberLamps));
            return result.ToString();
        }

        private static string AddLampsOn(int numberLampsOn, StatusLampEnum statusLamp)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < numberLampsOn; i++) // For each lamp on, add this to result
                result.Append(statusLamp.GetDescription());
            return result.ToString();
        }

        private static string AddLampsOff(int numberLampsOn, int totalNumberLamps)
        {
            StringBuilder result = new StringBuilder();
            for (int i = numberLampsOn; i < totalNumberLamps; i++) // for each lamp off, add this to result, until the end of the lamps in that row.
                result.Append(StatusLampEnum.OFF.GetDescription());
            return result.ToString();
        }
    }
}
