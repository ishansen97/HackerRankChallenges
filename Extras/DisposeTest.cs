using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankChallenges.Extras
{
	public class DisposeTest : IDisposable
	{
		public string Name { get; set; }

		public void Dispose()
		{
			Console.WriteLine("Disposing");
		}
	}
}
