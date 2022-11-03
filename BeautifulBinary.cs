using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankChallenges
{
    public class BeautifulBinary
    {
        public static int Prog(string b)
        {
            string pattern = "010";
            int count = 0;

            for (int i = 0; i <= b.Length - 3; )
            {
                string subText = b.Substring(i, 3);
                if (subText == pattern)
                {
                    count++;
                    i += 3;
                }
                else
                {
                    i++;
                }
            }

            return count;
        }
    }
}
