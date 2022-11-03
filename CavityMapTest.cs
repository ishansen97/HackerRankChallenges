using HackerRankChallenges.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankChallenges
{
    public class CavityMapTest
    {
        public static List<string> CavityMap(List<string> grid)
        {
			int items = 0;
			for (int i = 1; i < grid.Count - 1; i++)
			{
				for (int j = 1; j < grid[i].Length - 1; j++)
				{
					if (int.TryParse(grid[i][j].ToString(), out var current) &&
						int.TryParse(grid[i - 1][j].ToString(), out var above) &&
						int.TryParse(grid[i][j - 1].ToString(), out var prev) &&
						int.TryParse(grid[i][j + 1].ToString(), out var next) &&
						int.TryParse(grid[i + 1][j].ToString(), out var below)
					)
					{
						if ((current > above) &&
							(current > prev) &&
							(current > next) &&
							(current > below) 
						)
						{
							grid[i] = grid[i].Remove(j, 1);
							grid[i] = grid[i].Insert(j, "X");
						}
					}
					items++;
				}
			}

			Console.WriteLine(grid.EnumerableToString());
			Console.WriteLine(items);

            return default;
        }
    }
}
