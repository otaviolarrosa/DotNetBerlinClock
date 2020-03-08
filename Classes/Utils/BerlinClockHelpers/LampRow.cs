using BerlinClock.Classes.Utils.ExtensionMethods;
using System.Text;

namespace BerlinClock.Classes.Utils.BerlinClockHelpers
{
    internal static class LampRow
    {
        internal static string GetLampRow(int totalNumberLamps, int numberLampsOn, StatusLampEnum statusLamp)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < numberLampsOn; i++)
                sb.Append(statusLamp.GetDescription());

            for (int i = sb.ToString().Length; i < totalNumberLamps; i++)
                sb.Append("O");

            return sb.ToString();
        }
    }
}
