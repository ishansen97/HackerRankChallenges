using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankChallenges
{
    public class LisaWorkBookTest
    {
        public static int Workbook(int n, int k, List<int> arr)
        {
            int pageNo = 0, specialCount = 0;

			for (int i = 0; i < arr.Count; i++)
			{
				for (int j = 1; j <= arr[i]; j++)
				{
					if (j % k == 1 || k == 1)
					{
						pageNo++;
					}

					if (j == pageNo)
					{
						specialCount++;
					}
				}

			}

			return specialCount;
        }
    }
}
