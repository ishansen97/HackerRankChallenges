using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankChallenges
{
    public class LoveLetterPalindrome
    {
        public static int TheLoveLetterMystery(string text)
        {
            int length = text.Length;
            int occurrences = 0;

            for (int i = 0; i < length / 2; i++)
            {
                occurrences += Math.Abs(text[i] - text[length - i - 1]);
            }

            return occurrences;
        }
    }
}
