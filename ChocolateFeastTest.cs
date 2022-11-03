using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankChallenges
{
    public class ChocolateFeastTest
    {
        public static int ChocolateFeast(int initialAmount, int cost, int noOfWrappers)
        {
            int noOfChocolates = initialAmount / cost;
            int wrappersCollected = noOfChocolates;

            while (wrappersCollected >= noOfWrappers)
			{
                int group = wrappersCollected / noOfWrappers;
                wrappersCollected = (wrappersCollected - noOfWrappers) + group;
                noOfChocolates++;
			}

            return noOfChocolates;
        }
    }
}
