using System;
using System.Collections.Generic;
using System.Text;

namespace Number1._1_9_
{
    public class DoublyNode
    {
        public PriceList data;
        public DoublyNode Next;
        public DoublyNode Previous;
    }
    public class DoublyLinkedList
    {
        DoublyNode head = null;
        DoublyNode tail = null;
        public void View()
        {
            DoublyNode node = head;
            Console.WriteLine("|--------------------------------------------------------------|");
            Console.WriteLine($"{"|Наименование товара",-19}|{"Тип",-5}|{"Цена за 1 шт(грн)",-10}|{"Количество товаров",-5}{'|'}");
            Console.WriteLine("|--------------------------------------------------------------|");
            while (node != null)
            {
                Console.WriteLine($"|{node.data.nameofprod,-19}|{node.data.type,-5}{"|"+node.data.price,-18}{'|'}{node.data.quantity,-18}{'|'}");
                
                node = node.Next;
            }
            Console.WriteLine("|--------------------------------------------------------------|");
            Console.WriteLine($"{"|Перечисляемый тип: К - канцтовары, О - оргтехника"}{"|",14}");
            Console.WriteLine("|--------------------------------------------------------------|");

        }
        public void Add(string nameofprod1, Type type1, double price1, double quantity1)
        {
            DoublyNode node = new DoublyNode();
            node.data = new PriceList() { nameofprod = nameofprod1, type = type1, price = price1, quantity = quantity1 };
            node.Next = null;
            node.Previous = null;
            if (head == null)
                head = node;
            else
            {
                tail.Next = node;
                node.Previous = tail;
            }
            tail = node;
        }
        public void Delete(int deleteIndexStr)
        {
            DoublyNode node = head;
            for (int i = 0; i <= deleteIndexStr; i++)
            {
                if (i == deleteIndexStr)
                {
                    if (node.Next != null)
                        node.Next.Previous = node.Previous;
                    else
                        tail = node.Previous;
                    if (node.Previous != null)
                        node.Previous.Next = node.Next;
                    else
                        head = node.Next;
                }
                node = node.Next;
            }
        }
        public void Update(int selectIndexStr, string nameofprod1, Type type1, double price, double quantity1)
        {
            DoublyNode node = head;
            for (int i = 0; i <= selectIndexStr; i++)
            {
                if (i == selectIndexStr)
                {
                    node.data.nameofprod = nameofprod1;
                    node.data.type = type1;
                    node.data.price = price;
                    node.data.quantity = quantity1;
                }
                node = node.Next;
            }
        }
        public void Search(string searchprice)
        {
            double minprice = double.Parse(searchprice);
            Console.WriteLine("|--------------------------------------------------------------|");
            Console.WriteLine($"{"|Наименование товара",-19}|{"Тип",-5}|{"Цена за 1 шт(грн)",-10}|{"Количество товаров",-5}{'|'}");
            Console.WriteLine("|--------------------------------------------------------------|");
            for (DoublyNode node = head; node != null; node = node.Next)
            {
                if (node.data.price >= minprice)
                {
                    Console.WriteLine($"|{node.data.nameofprod,-19}|{node.data.type,-5}{"|" + node.data.price,-18}{'|'}{node.data.quantity,-18}{'|'}");
                }
                    
            }
            Console.WriteLine("|--------------------------------------------------------------|");
            Console.WriteLine($"{"|Перечисляемый тип: К - канцтовары, О - оргтехника"}{"|",14}");
            Console.WriteLine("|--------------------------------------------------------------|");
        }
    }
}
