using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankChallenges.Extensions
{
    public static class ExtensionsMethods
    {
        public static string EnumerableToString<T>(this IEnumerable<T> e)
		{
            return string.Join(",", e);
		}
    }
}
