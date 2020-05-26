using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_MatrixList_
{
    public class MatrixListNode<T>
    {
        public T data;
        public MatrixListNode<T> next;
        public MatrixListNode<T> prev;
    }
    public class MatrixList<T>
    {
        MatrixListNode<T> head = null;
        MatrixListNode<T> tail = null;
        public void ElemAdd(T elem)
        {
            MatrixListNode<T> node = new MatrixListNode<T>();
            node.data = elem;
            node.next = null;
            node.prev = null;
            if (head == null)
            {
                head = node;
            }
            else
            {
                tail.next = node;
                node.prev = tail;
            }
            tail = node;
        }
        public void PrintMatrix()
        {
            MatrixListNode<T> node = head;
            while (node != null)
            {
                Console.Write(node.data + " ");
                node = node.next;
            }
        }
        public MatrixListNode<T> Prepare(int Qnum)
        {
            MatrixListNode<T> node = head;
            for (int i = 0; i < Qnum; i++)
            {
                node = node.next;
            }
            return node;
        }
        public T GetNumber(int Qnum)
        {
            MatrixListNode<T> node = head;
            for (int i = 0; i < Qnum; i++)
            {
                node = node.next;
            }
            return node.data;
        }
    }
}
