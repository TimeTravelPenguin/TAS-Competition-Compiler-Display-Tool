using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASCompDisplay
{
	class NumberConverter
	{
		public string FormatTime(double frames)
		{
			string remainingString;

			//  61f = 1sec + 1f ~= 1.016667
			// Converts frames to seconds / milliseconds
			var seconds = frames / 60;
			var s = Math.Floor(seconds);
			var milli = Math.Round(seconds - s, 3) * 1000;
			int width = 5 - milli.ToString().Length;
			var ms = milli.ToString().PadLeft(width, '0');

			remainingString = $"{s}\"{ms}";

			return $"{remainingString}";
		}

		public string AddOrdinal(int num)
		{
			if (num <= 0) return num.ToString();

			switch (num % 100)
			{
				case 11:
				case 12:
				case 13:
					return num + "th";
			}

			switch (num % 10)
			{
				case 1:
					return num + "st";
				case 2:
					return num + "nd";
				case 3:
					return num + "rd";
				default:
					return num + "th";
			}

		}
	}


}
