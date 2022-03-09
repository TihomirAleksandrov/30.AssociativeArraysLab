using System;
using System.Linq;
using System.Collections.Generic;

namespace OddOccurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().Select(x => x.ToLower()).ToList();

            Dictionary<string, int> words = new Dictionary<string, int>();

            foreach (string word in input)
            {
                if (words.ContainsKey(word))
                {
                    words[word]++;
                }
                else
                {
                    words.Add(word, 1);
                }
            }

            foreach (var word in words)
            {
                if (word.Value % 2 != 0)
                {
                    Console.Write($"{word.Key} ");
                }
            }
        }
    }
}
