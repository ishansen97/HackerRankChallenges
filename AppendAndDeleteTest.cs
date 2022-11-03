using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankChallenges
{
    public class AppendAndDeleteTest
    {
        public static string AppendAndDelete(string initial, string toBe, int count)
        {
            if (initial.Length > toBe.Length + count)
            {
                return "NO";
            }

            return "YES";
        }
    }
}
