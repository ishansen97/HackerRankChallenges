using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankChallenges
{
    public class SherlockGCDTest
    {
        public static string SolveSherlock(List<int> numbers)
        {
            if (numbers.Contains(1)) return "YES";

            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = i+1; j <= numbers.Count - 1; j++)
                {
                    if (!IsGCDAvailable(numbers[i], numbers[j])) return "YES";
                }
            }

            return "NO";
        }

        private static bool IsGCDAvailable(int num1, int num2)
        {
            while (num2 != 0)
            {
                int temp = num2;
                num2 %= num1;
                num1 = temp;
            }

            return (num1 != 1);
        }

        // Function to return gcd of a and b
        public static int GCD(int a, int b)
        {
            if (a == 0)
                return b;
            return GCD(b % a, a);
        }

        // Function to find gcd of
        // array of numbers
        public static string FindGCD(List<int> arr)
        {
            int result = arr[0];
            for (int i = 1; i < arr.Count; i++)
            {
                result = GCD(arr[i], result);

                if (result == 1)
                {
                    return "YES";
                }
            }

            return "NO";
        }
    }
}
