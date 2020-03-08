namespace BerlinClock.Classes.Interfaces
{
    /// <summary>
    /// Responsible to calculate hours in a Berlin clock
    /// </summary>
    public interface IHours
    {
        /// <summary>
        /// This method is responsible to calculate the hours in a Berlin clock, based on hours in a 
        /// conventional clock.
        /// </summary>
        /// <param name="hours">The hours in a conventional clock</param>
        /// <returns>A string containing the result in that format: 
        /// OOOO
        /// OOOO
        /// With the values:
        /// R = RED, O = OFF
        /// Where the first line indicates the lamps that correspond to 5 hours
        /// and the second line, indicates the lamps that correspond to 1 hour
        /// </returns>
        string CalculateHours(int hours);
    }
}
