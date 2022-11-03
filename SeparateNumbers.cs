using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankChallenges
{
    public class SeparateNumbers
    {
        public static void SeparateNumbersProg(string text)
        {
            int index = 0, step = 1, textLength = text.Length;
            decimal min = decimal.MaxValue;
            bool isBeautiful = true;
            while (step <= textLength / 2)
            {
                if (index == 0)
                {
                    isBeautiful = true;
                }

                decimal num1 = decimal.Parse(text.Substring(index, step));
                int currentNumLength = num1.ToString().Length;
                decimal nextNum = num1 + 1;
                int nextNumLength = nextNum.ToString().Length;
                index += currentNumLength;

                if (index + nextNumLength > textLength)
                {
                    decimal remNum;
                    if (decimal.TryParse(text.Substring(index), out remNum) && remNum != nextNum)
                    {
                        isBeautiful = false;
                        min = decimal.MaxValue;
                    }
                    break;
                }

                decimal num2 = decimal.Parse(text.Substring(index, nextNumLength));

                if (num2 == nextNum)
                {
                    step = nextNumLength;
                    min = Math.Min(num1, min);
                }
                else
                {
                    index = 0;
                    step++;
                    isBeautiful = false;
                    min = decimal.MaxValue;
                }
            }

            if (isBeautiful && min != decimal.MaxValue)
            {
                Console.WriteLine($"YES {min}");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
