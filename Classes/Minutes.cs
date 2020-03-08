﻿using BerlinClock.Classes.Interfaces;
using BerlinClock.Classes.Utils.BerlinClockHelpers;
using System.Text;
using BerlinClock.Classes.Utils.ExtensionMethods;

namespace BerlinClock.Classes
{
    internal class Minutes : IMinutes
    {
        public string CalculateMinutes(int minutes)
        {
            int numberTopMinutesLamps = minutes / 5;
            int numberBottomMinutesLamps = minutes % 5;

            StringBuilder sb = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();

            for (int i = 1; i < 12; i++)
                sb2.Append(i <= numberTopMinutesLamps ? GetMinuteLampColour(i) : StatusLampEnum.OFF.GetDescription());

            sb.AppendLine(sb2.ToString());
            sb.Append(LampRow.GetLampRow(4, numberBottomMinutesLamps, StatusLampEnum.YELLOW));
            return sb.ToString();
        }

        private string GetMinuteLampColour(int index)
        {
            return index % 3 == 0 ?
                StatusLampEnum.RED.GetDescription() :
                StatusLampEnum.YELLOW.GetDescription();
        }
    }
}
