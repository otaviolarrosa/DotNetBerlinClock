using System.Text;

namespace BerlinClock.Classes.Utils
{
    internal static class LampRow
    {
        internal static string GetLampRow(int totalNumberLamps, int numberLampsOn, StatusLampEnum statusLamp)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < numberLampsOn; i++)
                sb.Append(EnumExtensions.GetDescription(statusLamp));

            for (int i = sb.ToString().Length; i < totalNumberLamps; i++)
                sb.Append("O");

            return sb.ToString();
        }
    }
}
