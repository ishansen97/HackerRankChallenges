using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankChallenges
{
    public class FlatLand
    {
        public static int FlatlandSpaceStations(int n, int[] c)
        {
            if (n == c.Length) return 0;

            int max = int.MinValue;

			for (int i = 0; i < n; i++)
			{
				if (!c.Contains(i))
				{
					int min = int.MaxValue;
					for (int j = 0; j < c.Length; j++)
					{
						int distance = Math.Abs(i - c[j]);
						if (distance < min)
						{
							min = distance;
						}
					}

					if (min > max)
					{
						max = min;
					}
				}
			}

			return max;
        }

		public static int FlatlandSpaceStations1(int n, int[] c)
        {
            if (n == c.Length) return 0;

            int max = int.MinValue;

			for (int i = 0; i < n; i++)
			{
				int min = int.MaxValue;
				for (int j = 0; j < c.Length; j++)
				{
					int distance = Math.Abs(i - c[j]);
					if (distance < min)
					{
						min = distance;
					}
				}

				if (min > max)
				{
					max = min;
				}
			}

			return max;
        }

		public static int FlatlandSpaceStations2(int n, int[] c)
        {
            if (n == c.Length) return 0;

            int max = int.MinValue;

			for (int i = 0; i < n; i++)
			{
				int min = int.MaxValue;
				for (int j = 0; j < c.Length; j++)
				{
					if (Math.Abs(i - c[j]) < min)
					{
						min = Math.Abs(i - c[j]);
					}
				}

				if (min > max)
				{
					max = min;
				}
			}

			return max;
        }

		public static int FlatlandSpaceStations3(int n, int[] c)
        {
            //if (n == c.Length) return 0;

			Array.Sort(c);

			int max = c[0];

			for (int i = 1; i < c.Length; i++)
			{
				int distance = (c[i] - c[i - 1]) / 2;
				if (distance > max)
				{
					max = distance;
				}
			}

			int lastDistance = (n - 1) - c[c.Length - 1];

			return (lastDistance > max) ? lastDistance : max;
        }

		public static int FlatlandSpaceStations4(int n, int[] c)
        {
            if (n == c.Length) return 0;

			//Array.Sort(c);

			List<int> mins = new List<int>();

			for (int i = 0; i < n; i++)
			{
				int min = int.MaxValue;
				for (int j = 0; j < c.Length; j++)
				{
					if (Math.Abs(i - c[j]) < min)
					{
						min = Math.Abs(i - c[j]);
					}
				}
				mins.Add(min);
			}

			return mins.Max();
        }



    }
}
