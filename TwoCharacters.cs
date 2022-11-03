using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankChallenges
{
    public class TwoCharacters
    {
        public static int TwoCharactersProg(string text)
        {
            var hashList = text.ToHashSet().Select(item => item.ToString()).ToList();
            if (hashList.Count == 2 && IsAlternative(text)) return text.Length;

            int maxLength = int.MinValue;

            for (int i = 0; i < hashList.Count; i++)
            {
                string tempText = text;
                string letter1 = hashList[i];
                for (int j = i + 1; j < hashList.Count; j++)
                {
                    string letter2 = hashList[j];

                    tempText = tempText.Replace(letter1, string.Empty);
                    tempText = tempText.Replace(letter2, string.Empty);

                    if (IsAlternative(tempText))
                    {
                        maxLength = Math.Max(tempText.Length, maxLength);
                    }

                    tempText = text;
                }
            }

            return (maxLength == int.MinValue) ? 0 : maxLength;
        }

        private static bool IsAlternative(string text)
        {
            var hashSet = text.ToHashSet();
            if (hashSet.Count != 2) return false;

            var charDict = hashSet.ToDictionary(x => x);

            // create default pattern
            char firstDictLetter = charDict[text[0]];
            char secondDictLetter = charDict[text[1]];

            for (int i = 2; i < text.Length - 1; i += 2)
            {
                char letter = text[i];
                char nextLetter = text[i + 1];

                if ((letter != firstDictLetter) || (nextLetter != secondDictLetter))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
