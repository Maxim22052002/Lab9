using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Number6._1_9_
{
	public class ListNode<T>
	{
		public ListNode(T data) { Data = data; }
		public T Data { get; set; }
		public ListNode<T> Next { get; set; }
	}
	public class List<T> : IEnumerable<T>
	{
		ListNode<T> head, tail;
		int counter;
		public void Add(T data)
		{
			ListNode<T> node = new ListNode<T>(data);
			if (head == null)
				head = node;
			else
				tail.Next = node;
			tail = node;
			counter++;
		}
		public bool ContainsElem(T data)
		{
			ListNode<T> currentelem = head;
			while (currentelem != null)
			{
				if (currentelem.Data.Equals(data))
					return true;
				currentelem = currentelem.Next;
			}
			return false;
		}
		public int Counter { get { return counter; } }
		IEnumerator IEnumerable.GetEnumerator() { return ((IEnumerable)this).GetEnumerator(); }
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			ListNode<T> currentelem = head;
			while (currentelem != null)
			{
				yield return currentelem.Data;
				currentelem = currentelem.Next;
			}
		}
	}
}
