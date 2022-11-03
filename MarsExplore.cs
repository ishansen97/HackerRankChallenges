using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankChallenges
{
    public class MarsExplore
    {
        public static int MarsExploreTest(string text)
        {
            int diffCount = 0;
            for (int i = 0; i <= text.Length - 3; i += 3)
            {
                if (text[i] != 'S') diffCount++;
                if (text[i+1] != 'O') diffCount++;
                if (text[i+2] != 'S') diffCount++;
            }

            return diffCount;
        }

        public static int MarsExploreTestBest(string text)
        {
            string sos = "SOS";
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != sos[i % 3]) count++;
            }
            return count;
        }
    }
}
