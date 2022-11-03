using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankChallenges
{
    public class Hackerrank
    {
        public static string HackerrankInString(string text)
        {
            string searchTerm = "hackerrank";
            if (text.Length < searchTerm.Length) return "NO";

            int prevIndex = -1;

            for (int i = 0; i < searchTerm.Length; i++)
            {
                prevIndex++;
                text = text[prevIndex..];
                int index = text.IndexOf(searchTerm[i]);
                if (index == -1) return "NO";
                prevIndex = index;
            }

            return "YES";
        }
    }
}
