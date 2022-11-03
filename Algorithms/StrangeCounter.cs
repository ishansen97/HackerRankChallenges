using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankChallenges.Algorithms
{
    public class StrangeCounter
    {
        public static long StrangeCounterTest(long number)
        {
            // 1 - finding the round.
            long round = 0, sum = 0;
            while (sum < number)
            {
                sum += 3 * (long)Math.Pow(2, round);
                round++;
            }

            // 2 - find the sum for the given round.
            long roundSum = GetSum(round);

            // 3 - subtract the number from the round sum.
            return roundSum - number;
        }

        private static long GetSum(long round)
        {
            if (round == 0) return 1;
            long sum = GetSum(round - 1) + 3 * (long)Math.Pow(2,round-1);
            return sum;
        }
    }
}
