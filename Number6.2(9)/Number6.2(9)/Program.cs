using System;
using System.Collections.Generic;

namespace Number6._2_9_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = new List<int>()  { 17, 22, 5, 59};
            List<int> secondList = new List<int>() { 22, 17, 5, 59 }; 
            int counter = 0;
            foreach (int i in secondList)
            {
                if (firstList.Contains(i))
                {
                    counter++;
                }
                    
            }
            if (counter == firstList.Count)
            {
                Console.WriteLine("Первый список содержит ВСЕ элементы второго.");
            }

            else
            {
                Console.WriteLine("Первый список содержит НЕ ВСЕ элементы второго.");
            }
                
        }
    }
}
