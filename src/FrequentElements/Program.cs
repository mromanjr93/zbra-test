using System;
using System.Collections.Generic;
using System.Linq;

namespace FrequentElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[]
            {
                1,
                1,
                1,
                2,
                2,
                3
            };

            var frequentElements = MostFrequentElements(2, numbers);

            foreach (var item in frequentElements)
            {
                Console.WriteLine("Number {0}", item);

            }

            Console.ReadKey();
        }

        public static int[] MostFrequentElements(int k, int[] numbers)
        {

            var output = numbers
                         .GroupBy(p => p)
                         .OrderByDescending(group => group.Count())
                         .Select(group => group.Key)
                         .ToList();


            var result = new List<int>();

            for (int i = 0; i < k; i++)
            {
                result.Add(output[i]);
            }

            return result.ToArray();
        }
    }
}
