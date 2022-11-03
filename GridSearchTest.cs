using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankChallenges
{
	public class GridSearchTest
	{
		public static string GridSearch(List<string> G, List<string> P)
		{
            int pattStrLength = P[0].Length;
            for (int row = 0; row <= G.Count - P.Count; row++)
            {
                for (int str = 0; str <= G[row].Length - pattStrLength; str++)
                {
                    bool allMatch = true;
                    for (int patRow = 0; patRow < P.Count; patRow++)
                    {
                        string subString = G[row + patRow].Substring(str, pattStrLength);
                        if (P[patRow] != subString)
                        {
                            allMatch = false;
                            break;
                        }
						Console.WriteLine(subString);
                    }
					Console.WriteLine("=================");

                    if (allMatch)
                    {
                        return "YES";
                    }
                }
            }

            return "NO";
        }
	}
}
