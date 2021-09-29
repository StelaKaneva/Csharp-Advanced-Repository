using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> wordCount = new Dictionary<string, int>();
            List<string> words = new List<string>();
            

            using (StreamReader readerWords = new StreamReader("../../../words.txt"))
            {
                string word = String.Empty;

                while ((word = readerWords.ReadLine()) != null)
                {
                    wordCount.Add(word, 0);
                    words.Add(word);
                }
            }

            using (StreamReader readerText = new StreamReader("../../../text.txt"))
            {
                string line = String.Empty;

                while ((line = readerText.ReadLine()) != null)
                {
                    foreach (string word in words)
                    {
                        string pattern = $"(?<=[^a-zA-Z]){word}(?=[^a-zA-Z])";
                        int count = Regex.Matches(line, pattern, RegexOptions.IgnoreCase).Count;
                        wordCount[word] += count;
                    }
                }
            }

            using (StreamWriter writer = new StreamWriter("../../../actualResult.txt"))
            {
                foreach (var word in wordCount.Keys.OrderByDescending(x => wordCount[x]))
                {
                    writer.WriteLine($"{word} - {wordCount[word]}");
                }
            }
        }
    }
}
