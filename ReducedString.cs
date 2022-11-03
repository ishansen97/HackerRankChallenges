using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HackerRankChallenges
{
    public class ReducedString
    {
        public static string ReducedStringTest(string text)
        {
            int index = 0;

            while (true)
            {
                if (index < text.Length - 1)
                {
                    char letter = text[index];
                    char nextLetter = text[index + 1];

                    if (letter == nextLetter)
                    {
                        // remove both
                        text = text.Remove(index, 2);
                        index = 0;
                    }
                    else
                    {
                        index++;
                    }
                }
                else
                {
                    break;
                }
            }

            return (text.Length == 0) ? "Empty String" : text;
        }

        public static string ReducedStringBuilderTest(string text)
        {
            StringBuilder sb = new StringBuilder(text);
            int index = 0;

            while (true)
            {
                if (index < sb.Length - 1)
                {
                    char letter = sb[index];
                    char nextLetter = sb[index + 1];

                    if (letter == nextLetter)
                    {
                        // remove both
                        sb.Remove(index, 2);
                        index = 0;
                    }
                    else index++;

                }
                else break;
            }

            return (sb.Length == 0) ? "Empty String" : sb.ToString();
        }

        public static string ReducedStringBuilderTest1(string text)
        {
            StringBuilder sb = new StringBuilder(text);
            int index = 0;

            while (true)
            {
                if (index < sb.Length - 1)
                {
                    if (sb[index] == sb[index + 1])
                    {
                        // remove both
                        sb.Remove(index, 2);
                        index = 0;
                    }
                    else index++;
                }
                else break;
            }
            return (sb.Length == 0) ? "Empty String" : sb.ToString();
        }


    }
}
