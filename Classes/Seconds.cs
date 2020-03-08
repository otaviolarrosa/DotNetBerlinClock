using BerlinClock.Classes.Interfaces;

namespace BerlinClock.Classes
{
    public class Seconds : ISeconds
    {
        public string CalculateSeconds(int seconds)
        {
            return seconds % 2 == 0 ? "Y" : "O";
        }
    }
}
