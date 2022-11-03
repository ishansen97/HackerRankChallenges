using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankChallenges
{
    public class MinimumDistances
    {
        public static int GetMinimumDistance(List<int> a)
		{
			int minDistance = int.MaxValue;

			for (int i = 0; i < a.Count - 1; i++)
			{
				for (int j = i + 1; j < a.Count; j++)
				{
					if (a[i] == a[j])
					{
						if ((j - i) < minDistance)
						{
							minDistance = j - i;
						}
					}
				}
			}

			return minDistance == int.MaxValue ? -1 : minDistance;
		}
    }
}
