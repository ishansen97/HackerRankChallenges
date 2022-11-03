using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankChallenges
{
    public class CamelCase
    {
        public static int CountCamelCase(string text)
        {
            int count = 1;

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsUpper(text[i])) count++;
            }

            return count;
        }

        public static int CountCamelCaseRegex(string text)
        {
            return text.Count(s => char.IsUpper(s)) + 1;
        }


    }
}
