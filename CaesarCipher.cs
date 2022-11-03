using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankChallenges
{
    public class CaesarCipher
    {
        public static string CaesarCipherTest(string s, int k)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                char letter = s[i];
                if (!char.IsLetter(letter))
                {
                    sb.Append(s[i].ToString());
                }
                else
                {
                    int upper = char.IsUpper(letter) ? (int)'Z' : (int)'z';
                    int lower = char.IsUpper(letter) ? (int)'A' : (int)'a';
                    int deviated = letter + k;
                    char result;

                    if (deviated > upper)
                    {
                        int difference = deviated - upper;
                        int remainder = difference % 26;
                        int addition = upper;
                        if (remainder != 0)
                        {
                            addition = lower - 1;
                        }
                        result = (char)(remainder + addition);
                    }
                    else
                    {
                        result = (char)deviated;
                    }

                    sb.Append(result.ToString());
                }
            }

            return sb.ToString();
        }
    }
}
