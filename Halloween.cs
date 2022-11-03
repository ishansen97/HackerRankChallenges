using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankChallenges
{
    public class Halloween
    {
        public static int howManyGames(int initialPrice, int deduction, int minPrice, int budget)
		{
			int sum = initialPrice, reducedPrice = initialPrice, gameCount = 0;
			
			while (sum <= budget)
			{
				reducedPrice -= deduction;
				gameCount++;

				if (reducedPrice >= minPrice)
				{
					sum += reducedPrice;
				}
				else
				{
					sum += minPrice;
				}
			}

			return gameCount;
		}
    }
}
