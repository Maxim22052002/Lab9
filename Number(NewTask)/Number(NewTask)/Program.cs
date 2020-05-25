using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Number_NewTask_
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathforwords = @"words.txt";
            string[] words = FileReader(pathforwords);
            Dictionary<string, int> periodicityWords = new Dictionary<string, int>();
            FillingDictionary(periodicityWords, words);
            SortedDictionary<string, int> sorterWords = new SortedDictionary<string, int>(periodicityWords);
            TenMostGeneralWords(sorterWords);
        }
        public static string[] FileReader(string pathforwords)
        {
            StreamReader reader = new StreamReader(pathforwords);
            string text = reader.ReadToEnd();
            string[] words = text.Split(' ');
            reader.Close();
            return words;
        }
        public static void FillingDictionary(Dictionary<string, int> periodicityWords, string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                if (periodicityWords.ContainsKey(words[i]))
                {
                    int value = periodicityWords[words[i]];
                    periodicityWords[words[i]] = value + 1;
                }
                else
                {
                    periodicityWords.Add(words[i], 1);
                }
                    
            }
        }
        public static void TenMostGeneralWords(SortedDictionary<string, int> sorterWords)
        {
            Console.WriteLine("10 most common words in a file: ");
            foreach (KeyValuePair<string, int> keyValuePair in sorterWords.OrderByDescending(key => key.Value).Take(10))
            {
                Console.WriteLine(keyValuePair.Key + " " + keyValuePair.Value);
            }
                
        }
    }
}
