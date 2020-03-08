namespace BerlinClock.Classes.Interfaces
{
    /// <summary>
    /// Responsible to calculate minutes in a Berlin clock
    /// </summary>
    public interface IMinutes
    {
        /// <summary>
        /// This method is responsible to calculate the minutes in a Berlin clock, based on minutes in a 
        /// conventional clock.
        /// </summary>
        /// <param name="minutes">The minutes in a conventional clock</param>
        /// <returns>A string containing the result in that format: 
        /// OOOOOOOOOOO
        /// OOOO
        /// With the values:
        /// Y = YELLOW, R = RED, O = OFF
        /// Where the first line indicates the lamps that correspond to 5 minutes and the quartes of hour in the 3rd, 6th and 9th lamps
        /// and, where the second line, indicates the lamps that correspond to one minute.
        /// </returns>
        string CalculateMinutes(int minutes);
    }
}
