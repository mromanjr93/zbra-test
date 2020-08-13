using System;

namespace Anagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Result of Anagram check of word {0} and {1}: {2}", "mary", "army", IsAnagram("mary", "army"));
            Console.WriteLine("Result of Anagram check of word {0} and {1}: {2}", "maryy", "army", IsAnagram("maryy", "army"));
            Console.WriteLine("Result of Anagram check of word {0} and {1}: {2}", "teacher", "cheater", IsAnagram("teacher", "cheater"));
            Console.WriteLine("Result of Anagram check of word {0} and {1}: {2}", "worker", "reworker", IsAnagram("worker", "reworker"));

            Console.ReadKey();
        }

        public static bool IsAnagram(string word1, string word2)
        {
            char[] ch1 = word1.ToLower().ToCharArray();
            char[] ch2 = word2.ToLower().ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);
            string val1 = new string(ch1);
            string val2 = new string(ch2);

            return (val1 == val2);
        }   
    }
}
