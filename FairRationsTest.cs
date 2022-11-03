using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankChallenges
{
    public class FairRationsTest
    {
        public static string FairRations(List<int> B)
        {
            if (B.Sum() % 2 == 1) return "NO";
            int count = 0;

			for (int i = 0; i < B.Count; i++)
			{
                if (B[i] % 2 == 1)
				{
                    B[i]++;
                    B[i + 1]++;
                    count += 2;
				}
			}

            return count.ToString();
        }
    }
}
