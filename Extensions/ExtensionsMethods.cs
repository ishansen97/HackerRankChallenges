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
            StringBuilder builder = new StringBuilder();

			foreach (var item in e)
			{
				builder.Append(string.Concat(item, ","));
			}

			builder.Remove(builder.Length - 1, 1);
			return builder.ToString();
		}
    }
}
