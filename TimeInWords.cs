using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankChallenges
{
    public class TimeInWords
    {
        public static string timeInWords(int hours, int minutes)
		{
            Dictionary<int, string> numberWords = new Dictionary<int, string>()
            {
                { 1, "one" },
                { 2, "two" },
                { 3, "three" },
                { 4, "four" },
                { 5, "five" },
                { 6, "six" },
                { 7, "seven" },
                { 8, "eight" },
                { 9, "nine" },
                { 10, "ten" },
                { 11, "eleven" },
                { 12, "twelve" },
                { 13, "thirteen" },
                { 14, "fourteen" },
                { 16, "sixteen" },
                { 17, "seventeen" },
                { 18, "eighteen" },
                { 19, "nineteen" }
            };

            Dictionary<int, string> tenMultipleWords = new Dictionary<int, string>()
            {
                { 1, "ten" },
                { 2, "twenty" }
            };

            Dictionary<int, string> quarters = new Dictionary<int, string>()
            {
                { 1, "quarter" },
                { 2, "half" }
            };

            string hourText = numberWords[hours];
            string minuteText = string.Empty;

            if (minutes == 0)
            {
                minuteText = @"o' clock";
                return string.Concat(hourText, " ", minuteText);
            }

            string relation = (minutes <= 30) ? "past" : "to";
            string text = (minutes == 1) || (60 - minutes == 1) ? " minute" : " minutes";

            if (minutes % 15 == 0)
			{
                if (minutes <= 30)
				{
                    minuteText = quarters[minutes / 15];
                }
                else
				{
                    hourText = numberWords[(hours + 1) % 12];
                    minuteText = quarters[4 - (minutes / 15)];
                }
			}

            else if (minutes <= 30)
			{
                if (minutes > 0 && minutes < 20)
				{
                    minuteText = numberWords[minutes - 0] + text;
				}
                else
				{
                    minuteText = tenMultipleWords[minutes / 10] + " " + numberWords[minutes % 10] + text;
				}
            }
            else
			{
                hourText = numberWords[(hours + 1) % 12];
                int rem = 60 - minutes;
                if (rem > 0 && rem < 20)
				{
                    minuteText = numberWords[rem - 0] + text;
				}
                else
                {
                    minuteText = tenMultipleWords[rem / 10] + " " + numberWords[rem % 10] + text;
                }
            }

            return minuteText + " " + relation + " " + hourText;
        }
    }
}
