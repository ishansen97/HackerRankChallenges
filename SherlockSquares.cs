using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankChallenges
{
    public class SherlockSquares
    {
        public static int Squares(int lower, int upper)
        {
            //if (lower == upper
            //        && (Math.Sqrt(lower) == (int)Math.Sqrt(lower))
            //        && (Math.Sqrt(upper) == (int)Math.Sqrt(upper)))
            //{
            //    return 1;
            //}

            //int lowerSqrt = (int)Math.Ceiling(Math.Sqrt(lower));
            //int upperSqrt = (int)Math.Floor(Math.Sqrt(upper));

            //return (lowerSqrt == upperSqrt) ? 0 : upperSqrt - lowerSqrt + 1;

            // answer from the editorial.
            // floor value of sqrt. of upper limit - ceiling value of sqrt. of lower limit + 1
            return (int)(Math.Floor(Math.Sqrt(upper)) - Math.Ceiling(Math.Sqrt(lower)) + 1);
        }
    }
}
