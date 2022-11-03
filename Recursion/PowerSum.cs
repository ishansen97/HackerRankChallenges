using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankChallenges.Recursion
{
    public class PowerSum
    {
        public static int GetPowerSum(int number, int power, int baseVal = 1)
        {
            if (number == 0)
            {
                return 1;
            }
            if ((int)Math.Pow(baseVal, power) > number)
            {
                return 0;
            }

            int firstHalf = GetPowerSum((number - (int)Math.Pow(baseVal, power)), power, baseVal + 1);
            int secondHalf = GetPowerSum(number, power, baseVal + 1);

            return firstHalf + secondHalf;
        }
    }
}
