using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankChallenges
{
    public class Highway
    {
        public static List<int> ServiceLane(int n, List<List<int>> cases, List<int> widths)
        {
            List<int> result = new List<int>();

			for (int i = 0; i < cases.Count; i++)
			{
                List<int> list = cases[i];
                int min = int.MaxValue;

				for (int j = list[0]; j <= list[1]; j++)
				{
                    if (widths[j] < min)
					{
                        min = widths[j];
					}
				}

                result.Add(min);
			}

            return result;
        }

    }
}
