using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankChallenges
{
    public class StonesTest
    {
        public static List<int> Stones(int n, int a, int b)
        {
            List<int> result = new List<int>();
            int smallest = (a < b) ? a : b;
            int largest = (a > b) ? a : b;
            int diff = Math.Abs(smallest - largest);

            int min = 0 + smallest * (n - 1);
            int max = 0 + largest * (n - 1);

			for (int i = min; i < max; i += diff)
			{
                result.Add(i);
			}

            result.Add(max);

			return result;
        }

        public static List<int> Stones1(int n, int a, int b)
        {
            List<int> result = new List<int>();
            int smallest = Math.Min(a, b);
            int largest = Math.Max(a,b);
            int diff = Math.Abs(a - b);

            int min = 0 + smallest * (n - 1);
            int max = 0 + largest * (n - 1);

			for (int i = min; i < max; i += diff)
			{
                result.Add(i);
			}

            result.Add(max);

			return result;
        }


    }
}
