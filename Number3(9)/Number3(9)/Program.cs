using System;
using System.IO;

namespace Number3_9_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст считалочки: ");
            string inlet = Console.ReadLine();
            Console.WriteLine("Введите имя человека, с которого начнется считалочка: ");
            string name = Console.ReadLine();
            string[] countingArray = CountingArray(inlet);
            string[] names = NamesArray();
            CountingList listnames = CountingListSet(names);
            Console.WriteLine("В результате считалочки выходит:");
            listnames.Counting(name, countingArray.Length);
        }
        static string[] NamesArray()
        {
            StreamReader read = File.OpenText(@"filenames.txt");
            
            string[] names = new string[10];
            for (int i = 0; i < names.Length; i++)
            {
                names[i] = read.ReadLine();
            }
            read.Close();
            return names;
        }
        static string[] CountingArray(string stringnames)
        {
            string[] array = stringnames.Split(new char[] { ' ' });
            return array;
        }
        static CountingList CountingListSet(string[] MassiveNames)
        {
            CountingList listnames = new CountingList();
            for (int i = 0; i < MassiveNames.Length; i++)
            {
                listnames.Add(MassiveNames[i]);
            }
            return listnames;
        }
    }
}
