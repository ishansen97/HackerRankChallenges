using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankChallenges
{
    public class BeautifulTriplets
    {
        public static int BeautifulTripletsTest(int diff, List<int> numbers)
        {
            int count = 0;
            for (int i = 0; i <= numbers.Count - 3; i++)
            {
                int initial = numbers[i];
                int otherNumCount = 0;

                for (int j = i + 1; j < numbers.Count; j++)
                {
                    int diff1 = numbers[j] - initial;
                    if (diff1 == diff)
                    {
                        initial = numbers[j];
                        otherNumCount++;
                    }

                    if (otherNumCount == 2)
                    {
                        count++;
                        break;
                    }
                }
            }

            return count;
        }
    }
}
