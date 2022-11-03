using HackerRankChallenges.Algorithms;
using HackerRankChallenges.Extensions;
using HackerRankChallenges.Extras;
using HackerRankChallenges.Recursion;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;

namespace HackerRankChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Min distance: {0}", MinimumDistances.GetMinimumDistance(new List<int>() { 3, 2, 1, 2, 3 }));
            //Console.WriteLine("Min distance: {0}", MinimumDistances.GetMinimumDistance(new List<int>() { 7, 1, 3, 4, 1, 7 }));

            //Console.WriteLine("Game count: {0}", Halloween.howManyGames(20, 3, 6, 70));
            //Console.WriteLine("Game count: {0}", Halloween.howManyGames(20, 3, 6, 80));
            //Console.WriteLine("Game count: {0}", Halloween.howManyGames(20, 3, 6, 85));

            //Console.WriteLine("Time: {0}", TimeInWords.timeInWords(5, 25));
            //Console.WriteLine("Time: {0}", TimeInWords.timeInWords(3, 55));
            //Console.WriteLine("Time: {0}", TimeInWords.timeInWords(2, 15));
            //Console.WriteLine("Time: {0}", TimeInWords.timeInWords(2, 30));
            //Console.WriteLine("Time: {0}", TimeInWords.timeInWords(2, 0));
            //Console.WriteLine("Time: {0}", TimeInWords.timeInWords(12, 45));
            //Console.WriteLine("Time: {0}", TimeInWords.timeInWords(7, 29));

            //HalloweenTest();

            //HighwayTest();

            //LisaWorkbookTest();

            //Activities.Prog();
            //FlatLandTest();
            /*
			BreadLoavesTest();
			CavityMapTest();*/

            //StonesTest();
            //GridSearchTest();

            //GCDTest();
            //CaesarCipherTest();

            //string text = "SOSTOT";
            //MarsExploreTest();

            //HackerrankFindTest();

            //RangingSubstringPerformance();

            //BeautifulTripletsTest();
            //BeautifulBinaryTest();

            //ReducedStringTest();

            //CamelCaseTest();

            //TwoCharactersTest();

            //PalindromeIndexTest();

            //LoveLetterPalindromeTest();

            //SeparateNumbersTest();
            //StrangeCounterTest();

            //PowerSumTest();
            //SherlockArraysTest();
            //SherlockSquaresTest();
        }

        private static void SherlockSquaresTest()
        {
            //Console.WriteLine($"Count: {SherlockSquares.Squares(25, 49)}");
            //Console.WriteLine($"Count: {SherlockSquares.Squares(228, 919)}");
            //Console.WriteLine($"Count: {SherlockSquares.Squares(11, 734)}");
            Console.WriteLine($"Count: {SherlockSquares.Squares(180, 447)}");
            //Console.WriteLine($"Count: {SherlockSquares.Squares(17, 24)}");
            //Console.WriteLine($"Count: {SherlockSquares.Squares(35, 70)}");
            //Console.WriteLine($"Count: {SherlockSquares.Squares(100,1000)}");
            //Console.WriteLine($"Count: {SherlockSquares.Squares(213,874)}");
            //Console.WriteLine($"Count: {SherlockSquares.Squares(300,346)}");
        }

        private static void SherlockArraysTest()
        {
            //int[] array = { 1, 2, 3, 3 };
            //int[] array = { 1, 2, 3 };
            int[] array = { 2, 0, 0, 0 };
            //int[] array = { 5, 6, 8, 11 };
            //int[] array = { 1 };
            List<int> list = array.ToList();

            // big collection
            List<int> bigList = Enumerable.Range(1, 10000).Select(i => (int)(new Random().NextDouble() * i)).ToList();
            string result = SherlockAndArray.BalancedSums(array);
            string result1 = SherlockAndArray.BalancedSumsSolution(bigList);
            Console.WriteLine($"Result: {result}");
            Console.WriteLine($"Result: {result1}");
        }

        private static void PowerSumTest()
        {
            int number = 29, power = 2;
            int powerSumSets = PowerSum.GetPowerSum(number, power);
            Console.WriteLine($"sets: {powerSumSets}");
        }

        private static void StrangeCounterTest()
        {
            Console.WriteLine("Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Value: {StrangeCounter.StrangeCounterTest(number)}");
        }

        private static void SeparateNumbersTest()
        {
            //string text = "123456";
            //string text = "010203";
            //string text = "1";
            //string text = "99100";
            //string text = "58589967442418995858996744241900";
            //string text = "88888888888888888888888888888888";
            //string text = "10001001100210031004100510061007";
            //string text = "00000000000000000000000000000000";
            //string text = "11111111111111111111111111111111";
            //string text = "96589218797811259658921879781126";
            //string text = "99100101";
            //string text = "4294967295000102003004005";
            string text = "42949672954294967296429496729";
            //string text = "9101112";
            //string text = "101103";
            //string text = "13";

            string input = "1234 91011 99100 101103 010203 13 1";

            //Console.WriteLine($"double max: {double.MaxValue}");
            //Console.WriteLine($"decimal max: {decimal.MaxValue}");
            //Console.WriteLine(decimal.Parse("9658921879781125", NumberStyles.Integer));
            //Console.WriteLine(decimal.Parse("9999999999999927"));

            //string[] fileInput = File.ReadAllLines(@"Files\sep_test_case_16.txt");
            string[] fileInput = File.ReadAllLines(@"Files\sep_test_case_20.txt");
            int inputs = int.Parse(fileInput[0]);

            for (int i = 1; i < inputs; i++)
            {
                //Console.WriteLine($"Number: {fileInput[i]}");
                SeparateNumbers.SeparateNumbersProg(fileInput[i]);
                Console.WriteLine("========================");
            }
        }

        private static void LoveLetterPalindromeTest()
        {
            //string text = "abc";
            string text = "cba";
            Console.WriteLine($"No. of occurrences: {LoveLetterPalindrome.TheLoveLetterMystery(text)}");
        }

        private static void PalindromeIndexTest()
        {
            //string text = "aaab";
            //string text = "baa";
            //string text = "aaaa";
            //string text = "bcbc";
            //string text = "fyjwtatuieusvfqaeynaaiiaanyeaqfvsueutatwjyf";
            string text = "qaaiyrpadovfjrmgkildtkseysejdtrpltptujlxxljutptlprtdjesyeskdlikgmrjfvodapryiaaq";
            Console.WriteLine($"text: {text}, Index: {PalindromeIndex.GetPalindromeIndex(text)}");
        }

        private static void TwoCharactersTest()
        {
            string text = "beabeefeab";
            //string text = "abaacdabd";
            //string text = "aba";
            //string text = "cwomzxmuelmangtosqkgfdqvkzdnxerhravxndvomhbokqmvsfcaddgxgwtpgpqrmeoxvkkjunkbjeyteccpugbkvhljxsshpoymkryydtmfhaogepvbwmypeiqumcibjskmsrpllgbvc";
            //string text = "txnbvnzdvasknhlmcpkbxdvofimsvqbvkswlkrchohwuplfujvlwpxtlcixpajjpaskrnjneelqdbxtiyeianqjqaikbukpicrwpnjvfpzolcredzmfaznnzd";
            //string text = "asdcbsdcagfsdbgdfanfghbsfdab";
            Console.WriteLine($"Max length: {TwoCharacters.TwoCharactersProg(text)}");

            //Console.WriteLine(TwoCharacters.IsAlternative("zxzxzxzx"));
        }

        private static void CamelCaseTest()
        {
            string text = "oneTwoThree";
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            Console.WriteLine($"Word count: {CamelCase.CountCamelCase(text)}");
            stopwatch.Stop();
            Console.WriteLine($"Time (mine): {stopwatch.ElapsedTicks}");

            stopwatch.Restart();
            Console.WriteLine($"Word count: {CamelCase.CountCamelCaseRegex(text)}");
            stopwatch.Stop();
            Console.WriteLine($"Time (suggested): {stopwatch.ElapsedTicks}");
        }

        private static void ReducedStringTest()
        {
            //string text = "aaabccddd";
            //string text = "baab";
            //string text = "aa";
            string text = "zztqooauhujtmxnsbzpykwlvpfyqijvdhuhiroodmuxiobyvwwxupqwydkpeebxmfvxhgicuzdealkgxlfmjiucasokrdznmtlwh";
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine($"String: {ReducedString.ReducedStringTest(text)}");
            stopwatch.Stop();
            Console.WriteLine($"Time (string): {stopwatch.ElapsedTicks}");

            stopwatch.Restart();
            Console.WriteLine($"String: {ReducedString.ReducedStringBuilderTest(text)}");
            stopwatch.Stop();
            Console.WriteLine($"Time (stringbuilder): {stopwatch.ElapsedTicks}");

            stopwatch.Restart();
            Console.WriteLine($"String: {ReducedString.ReducedStringBuilderTest1(text)}");
            stopwatch.Stop();
            Console.WriteLine($"Time (stringbuilder1): {stopwatch.ElapsedTicks}");
        }

        private static void BeautifulBinaryTest()
        {
            //string text = "0101010";
            string text = "0100101010";
            //string text = "01100";
            //string text = "0100101010100010110100100110110100011100111110101001011001110111110000101011011111011001111100011101";
            Console.WriteLine($"count; {BeautifulBinary.Prog(text)}");
        }

        private static void BeautifulTripletsTest()
        {
            List<int> numbers = new List<int>() { 1, 2, 4, 5, 7, 8, 10 };
            //List<int> numbers = new List<int>() { 2,2,3,4,5 };
            //int diff = 1;
            int diff = 3;
            int count = 0;

            Console.WriteLine("count: {0}", count);

            Console.WriteLine($"count: {BeautifulTriplets.BeautifulTripletsTest(diff, numbers)}");
        }

        private static void RangingSubstringPerformance()
        {
            List<string> list1 = new List<string>();
            List<string> list2 = new List<string>();

            string mainWord = "wordwordword";

            for (int i = 0; i < 1000; i++)
            {
                string word = string.Concat(mainWord, "/", i);
                list1.Add(word);
                list2.Add(word);
            }

            Stopwatch watch = new Stopwatch();

            watch.Start();
            foreach (var word in list1)
            {
                string subWord = word[1..8];
            }
            watch.Stop();
            Console.WriteLine($"Elapsed time (range): {watch.ElapsedTicks}");

            watch.Restart();
            foreach (var word in list2)
            {
                string subWord = word.Substring(1, 7);
            }
            watch.Stop();
            Console.WriteLine($"Elapsed time (substring): {watch.ElapsedTicks}");
        }

        private static void HackerrankFindTest()
        {
            string script = "knarrekcah hackerrank hackeronek abcdefghijklmnopqrstuvwxyz rhackerank ahankercka hacakaeararanaka hhhhaaaaackkkkerrrrrrrrank crackerhackerknar hhhackkerbanker";
            string text = "rhackerank";
            Console.WriteLine($"Text Contains: {Hackerrank.HackerrankInString(text)}");
            foreach (var word in script.Split(" "))
            {
                Console.WriteLine($"Contains: {Hackerrank.HackerrankInString(word)}");
            }
        }

        private static void MarsExploreTest()
        {
            Stopwatch watch = new Stopwatch();
            string text = "SOSSPSSQSSORSOA";
            //string text = "SOSSOT";
            watch.Start();
            Console.WriteLine($"count: {MarsExplore.MarsExploreTest(text)}");
            watch.Stop();
            Console.WriteLine($"Time taken (Ishan): {watch.ElapsedTicks}");

            watch.Restart();
            Console.WriteLine($"count: {MarsExplore.MarsExploreTestBest(text)}");
            watch.Stop();
            Console.WriteLine($"Time taken (Other): {watch.ElapsedTicks}");
        }

        private static void CaesarCipherTest()
        {
            //string word = "middle-Outz";
            //string word = "There's-a-starman-waiting-in-the-sky";
            string word = "159357lcfd";
            //string word = "!m-rB`-oN!.W`cLAcVbN/CqSoolII!SImji.!w/`Xu`uZa1TWPRq`uRBtok`xPT`lL-zPTc.BSRIhu..-!.!tcl!-U";
            int offset = 98;

            Console.WriteLine("Result: {0}", CaesarCipher.CaesarCipherTest(word, offset));
            Console.WriteLine("f: {0}", (int)'f');
            Console.WriteLine("l: {0}", (int)'l');
            Console.WriteLine("': {0}", (int)'\'');
            Console.WriteLine("Result: {0}", ((int)'f' + 98));
        }

        private static void GCDTest()
        {
            string sample = "5106 73623 20833 80256 83114 18694 55464 13975 30694 5735 2005 95231 61104 35301 "
                            + "49033 59523 5839 44215 65183 90295 14660 62782 47981 34999 86633 3205 89409 87661 53522 " +
                            "86434 76773 26186 44365 43601 10973 76810 1283 81629 44165 84818 67574 75769 60213 57427 " +
                            "21667 61632 52287 79494 5823 33242 38381 76655 79836 60280 98437 85051 5602 3893 81478 53284";

            List<int> list = sample.Split(" ").Select(s => Convert.ToInt32(s)).ToList();
            //List<int> numbers = new List<int>() { 5, 5, 5 };
            //List<int> numbers = new List<int>() { 1,2,3 };
            List<int> numbers = new List<int>() { 2 };


            //Console.WriteLine($"Response: {SherlockGCDTest.SolveSherlock(numbers)}");
            //Console.WriteLine($"Response: {SherlockGCDTest.SolveSherlock(list)}");
            Console.WriteLine($"Response: {SherlockGCDTest.FindGCD(list)}");
            Console.WriteLine($"GCD: {SherlockGCDTest.GCD(14, 17)}");
        }

        private static void GridSearchTest()
        {
            List<string> grid = new List<string>()
            {
                "7283455864",
                "6731158619",
                "8988242643",
                "3830589324",
                "2229505813",
                "5633845374",
                "6473530293",
                "7053106601",
                "0834282956",
                "4607924137"
            };

            List<string> pattern = new List<string>() { "9505", "3845", "3530" };

            List<string> grid1 = new List<string>()
            {
                "999999",
                "121211"
            };

            List<string> pattern1 = new List<string>() { "99", "11" };

            Console.WriteLine(HackerRankChallenges.GridSearchTest.GridSearch(grid, pattern));
            Console.WriteLine(HackerRankChallenges.GridSearchTest.GridSearch(grid1, pattern1));
        }

        private static void StonesTest()
        {
            Stopwatch sw = new Stopwatch();
            //Console.WriteLine("result: {0}", StonesTest.Stones(3, 1, 2).EnumerableToString());
            //Console.WriteLine("result: {0}", StonesTest.Stones(4, 10, 100).EnumerableToString());
            //Console.WriteLine("result: {0}", StonesTest.Stones(2, 1, 1).EnumerableToString());
            //Console.WriteLine("result: {0}", StonesTest.Stones(100, 1, 1).EnumerableToString());

            sw.Start();
            //Console.WriteLine("result: {0}", StonesTest.Stones(999, 1, 2).EnumerableToString());
            HackerRankChallenges.StonesTest.Stones(999, 1, 2);
            sw.Stop();
            Console.WriteLine("time taken (1): {0}", sw.ElapsedTicks);

            sw.Restart();
            //Console.WriteLine("result: {0}", StonesTest.Stones(999, 1, 2).EnumerableToString());
            HackerRankChallenges.StonesTest.Stones1(999, 1, 2);
            sw.Stop();
            Console.WriteLine("time taken (2): {0}", sw.ElapsedTicks);
        }

        private static void CavityMapTest()
        {
            HackerRankChallenges.CavityMapTest.CavityMap(new List<string>() { "1112", "1912", "1892", "1234" });
        }

        private static void BreadLoavesTest()
        {
            Console.WriteLine("Min Loaves: {0}", FairRationsTest.FairRations(new List<int>() { 2, 3, 4, 5, 6 }));
            //Console.WriteLine("Min Loaves: {0}", FairRationsTest.FairRations(new List<int>() { 3, 8, 4, 6, 1, 9, 8, 8, 6, 7, 5 }));
            //Console.WriteLine("Min Loaves: {0}", FairRationsTest.fairRations(new List<int>() { 4, 5, 6, 7 }));
        }

        private static void FlatLandTest()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Console.WriteLine("max distance: {0}", FlatLand.FlatlandSpaceStations(15, new int[] { 0, 2, 4 }));
            sw.Stop();
            Console.WriteLine("time elapsed (0): {0}", sw.ElapsedTicks);

            sw.Restart();
            Console.WriteLine("max distance: {0}", FlatLand.FlatlandSpaceStations1(15, new int[] { 0, 2, 4 }));
            sw.Stop();
            Console.WriteLine("time elapsed (1): {0}", sw.ElapsedTicks);

            sw.Restart();
            Console.WriteLine("max distance: {0}", FlatLand.FlatlandSpaceStations2(15, new int[] { 0, 2, 4 }));
            sw.Stop();
            Console.WriteLine("time elapsed (2): {0}", sw.ElapsedTicks);

            sw.Restart();
            Console.WriteLine("max distance: {0}", FlatLand.FlatlandSpaceStations3(15, new int[] { 0, 2, 4 }));
            sw.Stop();
            Console.WriteLine("time elapsed (3): {0}", sw.ElapsedTicks);

            sw.Restart();
            Console.WriteLine("max distance: {0}", FlatLand.FlatlandSpaceStations4(15, new int[] { 0, 2, 4 }));
            sw.Stop();
            Console.WriteLine("time elapsed (4): {0}", sw.ElapsedTicks);
        }

        private static void LisaWorkbookTest()
        {
            //List<int> list = new List<int>() { 4,2,6,1,10 };
            List<int> list = new List<int>() { 100 };
            //Console.WriteLine("special numbers: {0}", LisaWorkBookTest.Workbook(5, 8, list));
            Console.WriteLine("special numbers: {0}", LisaWorkBookTest.Workbook(1, 1, list));
        }

        private static void HighwayTest()
        {
            List<List<int>> cases = new List<List<int>>()
            {
                new List<int>() { 0, 3 },
                new List<int>() { 4, 6 },
                new List<int>() { 6, 7 },
                new List<int>() { 3, 5 },
                new List<int>() { 0, 7 }
            };

            List<int> widths = new List<int>() { 2, 3, 1, 2, 3, 2, 3, 3 };

            Console.WriteLine("list: {0}", ExtensionsMethods.EnumerableToString(Highway.ServiceLane(8, cases, widths)));
        }

        private static void HalloweenTest()
        {
            Console.WriteLine("No of chocolates collected: {0}", ChocolateFeastTest.ChocolateFeast(6, 2, 2));
            Console.WriteLine("No of chocolates collected: {0}", ChocolateFeastTest.ChocolateFeast(7, 3, 2));
            Console.WriteLine("No of chocolates collected: {0}", ChocolateFeastTest.ChocolateFeast(10, 2, 5));
            Console.WriteLine("No of chocolates collected: {0}", ChocolateFeastTest.ChocolateFeast(1576, 9, 645));
            Console.WriteLine("No of chocolates collected: {0}", ChocolateFeastTest.ChocolateFeast(38843, 304, 30098));
            Console.WriteLine("No of chocolates collected: {0}", ChocolateFeastTest.ChocolateFeast(87354, 869, 5522));
        }
    }
}
