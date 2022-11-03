using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankChallenges
{
    public class SherlockAndArray
    {
        public static string BalancedSums(int[] array)
        {
            string result = "No";
            /*for (int i = 0; i < array.Length - 1; i++)
            {
                result = "Yes";
                int sum1 = 0, sum2 = 0;
                for (int left = 0; left < i; left++)
                {
                    sum1 = sum1 + array[left];
                }

                for (int right = i + 1; right < array.Length; right++)
                {
                    sum2 = sum2 + array[right];
                }

                if (sum1 == sum2)
                {
                    result = "Yes";
                }
            }*/
            int leftSum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i - 1 > -1)
                {
                    leftSum += array[i - 1];
                }

                int rightSum = 0;
                for (int right = i + 1; right <= array.Length - 1; right++)
                {
                    rightSum = rightSum + array[right];
                }

                if (leftSum == rightSum)
                {
                    result = "YES";
                }
            }

            return result;
        }

        public static string BalancedSums(List<int> array)
        {
            string result = "No";
            int leftSum = 0;
            for (int i = 0; i < array.Count; i++)
            {
                if (i - 1 > -1)
                {
                    leftSum += array[i - 1];
                }

                int rightSum = 0;
                for (int right = i + 1; right <= array.Count - 1; right++)
                {
                    rightSum = rightSum + array[right];
                }

                if (leftSum == rightSum)
                {
                    result = "YES";
                }
            }

            return result;
        }

        public static string BalancedSumsSolution(List<int> array)
        {
            /* EXPLANATION
             *  1) declare left, right variables where right is initialized to sum of the array.
             *  2) In each iteration, reduce the right value by decrementing from the current value.
             *  3) if left and right values are equal, return "YES"
             *  4) else, increment the left value by the current value and keep looping.
             */

            int left = 0;
            int right = array.Sum();

            for (int i = 0; i < array.Count; i++)
            {
                int pivot = array[i];
                right -= pivot;
                if (left == right) return "YES";

                left += pivot;

            }

            return "NO";
        }
    }
}
