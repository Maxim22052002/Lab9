using System;
using System.Collections.Generic;

namespace Number4_9_
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> datainfo = new Dictionary<string, int> { };
            int counter = Convert.ToInt32(Math.Pow(100000, 1.0 / 3));
            AmountForCubes(datainfo, counter);
            CheckForCubes(datainfo);
        }
        public static void AmountForCubes(Dictionary<string, int> datainfo, int counter)
        {
            for (int i = 1; i <= counter; i++)
            {
                for (int j = 1; j <= counter; j++)
                {
                    for (int k = 1; k <= counter; k++)
                    {
                        double iex3 = Math.Pow(i, 3);
                        double jex3 = Math.Pow(j, 3);
                        double kex3 = Math.Pow(k, 3);
                        int AmountCubs = Convert.ToInt32(iex3 + jex3 + kex3);
                        string AmountStr = "Кубические корни N(Number): " + i + " , " + j + " , " + k;
                        datainfo.Add(AmountStr, AmountCubs);
                    }
                }
            }
        }
        public static void CheckForCubes(Dictionary<string, int> datainfo)
        {
            int[] Masschecker = new int[100000];
            foreach (KeyValuePair<string, int> Number in datainfo)
            {
                if (Number.Value < Masschecker.Length)
                {
                    Masschecker[Number.Value]++;
                }
                    
            }
            for (int i = 1; i < Masschecker.Length; i++)
            {
                if (Masschecker[i] >= 6)
                {
                    Console.WriteLine(i);
                }
                    
            }
        }
    }
}
