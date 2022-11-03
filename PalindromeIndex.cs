using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankChallenges
{
    public class PalindromeIndex
    {
        public static int GetPalindromeIndex(string text)
        {
            int length = text.Length - 1;
            for (int i = 0; i < text.Length; i++)
            {
                string subStr = text.Remove(i, 1);
                if (IsPalindrome(subStr, length, i))
                {
                    return i;
                }
            }

            return -1;
        }

        private static bool IsPalindrome(string text, int length, int? index = null)
        {
            for (int i = 0; i < length / 2; i++)
            {
                if (text[i] != text[length - i - 1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
