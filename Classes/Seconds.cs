using BerlinClock.Classes.Enums;
using BerlinClock.Classes.Interfaces;
using BerlinClock.Classes.Utils.ExtensionMethods;

namespace BerlinClock.Classes
{
    public class Seconds : ISeconds
    {
        public string CalculateSeconds(int seconds)
        {
            return seconds % 2 == 0 ? StatusLampEnum.YELLOW.GetDescription() : StatusLampEnum.OFF.GetDescription();
        }
    }
}
