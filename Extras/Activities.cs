using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankChallenges.Extras
{
    public class Activities
    {
        public static void Prog()
		{
			//Console.WriteLine("second largest: {0}", FindSecondLargest(new int[] { 25, 16, 1, 45, 38, 78, 981, 561, 1000, 211 }));
			Console.WriteLine("second largest: {0}", FindNthLargest(new int[] { 67, 81, 22, 11, 90, 99, 134, 123, 125, 200, 322, 201 }, 5));
		}

		static int FindSecondLargest(int[] arr)
		{
            int largest = int.MinValue, secondLargest = int.MinValue, thirdLargest = int.MinValue, fourthLargest = int.MinValue;

			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] > largest)
				{
					fourthLargest = thirdLargest;
					thirdLargest = secondLargest;
					secondLargest = largest;
					largest = arr[i];
				}
				else if (arr[i] > secondLargest)
				{
					fourthLargest = thirdLargest;
					thirdLargest = secondLargest;
					secondLargest = arr[i];
				}
				else if (arr[i] > thirdLargest)
				{
					fourthLargest = thirdLargest;
					thirdLargest = arr[i];
				}
				else if (arr[i] > fourthLargest)
				{
					fourthLargest = arr[i];
				}
			}

			//return secondLargest;
			//return thirdLargest;
			return fourthLargest;
		}

		static int FindNthLargest(int[] arr, int n)
		{
			if (n > arr.Length)
			{
				string term = (n == 1) ? "st" : "th";
				throw new IndexOutOfRangeException($"The {n}{term} term does not exist.");
			}

			int length = arr.Length;
			int[] largestItems = new int[n];
			Array.Fill(largestItems, int.MinValue);

			for (int i = 0; i < length - 1; i++)
			{
				if (arr[i] > largestItems[0])
				{
					for (int j = n - 1; j > 0; j--)
					{
						largestItems[j] = largestItems[j - 1];
					}
					largestItems[0] = arr[i];
				}

				for (int k = 0; k < n - 1; k++)
				{
					if (arr[i] > largestItems[i + 1] && arr[i] < largestItems[i])
					{
						for (int j = n - 1; j > 0; j--)
						{
							largestItems[j] = largestItems[j - 1];
						}
						largestItems[i + 1] = arr[i];
					}
				}
			}

			return largestItems[n - 1];
		}


    }
}
