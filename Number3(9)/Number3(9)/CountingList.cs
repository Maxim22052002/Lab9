using System;
using System.Collections.Generic;
using System.Text;

namespace Number3_9_
{
    class ListNode
    {
        public string data;
        public ListNode next;
    }

    public class CountingList
    {
        ListNode head = null;
        ListNode tail = null;
        public void Add(string FileNames)
        {
            ListNode node = new ListNode();
            node.data = FileNames;
            node.next = null;
            if (head == null)
            {
                head = node;
                tail = node;
                tail.next = head;
            }
            else
            {
                node.next = head;
                tail.next = node;
                tail = node;
            }
        }
        public void Print()
        {
            ListNode node = head;
            while (node != tail)
            {
                Console.WriteLine(node.data);
                node = node.next;
            }
            Console.WriteLine(tail.data);
        }
        public void Counting(string strname, int numberStr)
        {
            ListNode node = new ListNode();
            node = head;
            ListNode run;
            while (node != tail)
            {
                if (node.data == strname)
                {
                    run = node;
                    goto adder;
                }
                else
                {
                    node = node.next;
                }
            }
            if (tail.data == strname)
            {
                run = tail;
            }
            else
            {
                Console.WriteLine("Проверьте введеное имя. Такого человека нет среди участников.");
                return;
            }
        adder:
            for (int i = 1; i < numberStr; i++)
            {
                run = run.next;
                if (i == numberStr - 1)
                {
                    Console.WriteLine(run.data);
                }
            }
        }
    }
}
