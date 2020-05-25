using System;

namespace Number6._1_9_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = new List<int>()  { 7, 13, 21, 15 };
            List<int> secondList = new List<int>() { 7, 21, 15, 13 }; 
            int counter = 0;
            foreach (int i in secondList)
            {
                if (firstList.ContainsElem(i))
                {
                    counter++;
                }
                    
            }
            if (counter == firstList.Counter)
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
