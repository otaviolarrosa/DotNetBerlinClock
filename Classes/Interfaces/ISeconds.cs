namespace BerlinClock.Classes.Interfaces
{
    /// <summary>
    /// Responsible to calculate seconds in a Berlin clock
    /// </summary>
    public interface ISeconds
    {
        /// <summary>
        /// This method is responsible to calculate the seconds in a Berlin clock, based on hours in a 
        /// conventional clock.
        /// </summary>
        /// <param name="seconds">The hours in a conventional clock</param>
        /// <returns>
        /// A string containing the result in that format:
        /// O
        /// With the values:
        /// Y = YELLOW, O = OFF
        /// When the result is Y, it indicates that the seconds is even, 
        /// and when the result is O, it indicates that the seconds is odd.
        /// </returns>
        string CalculateSeconds(int seconds);
    }
}
