using System;
using System.Linq;
using System.Collections.Generic;

namespace CountRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToList();

            SortedDictionary<int, int> numbers = new SortedDictionary<int, int>();

            foreach (int i in input)
            {
                if (numbers.ContainsKey(i))
                {
                    numbers[i]++;
                }
                else
                {
                    numbers.Add(i, 1);
                }
            }

            foreach (var number in numbers)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}
