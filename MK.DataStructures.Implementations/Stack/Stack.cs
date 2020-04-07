using System;

namespace MK.DataStructures.Implementations.Stack
{
	/// <summary>
	/// Stack implementation (LIFO)
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class Stack<T> : IStack<T>
	{
		private List.ILinkedList<T> list = new List.LinkedList<T>();

		public void Clear()
		{
			this.list = null;
		}

		public IStack<T> Pop()
		{
			if (!this.list.Any())
				throw new Exception("Stack is empty.");

			this.list.RemoveFirst();
			return this;
		}

		public IStack<T> Push(INode<T> node)
		{
			if (node == null) throw new ArgumentNullException();
			
			this.list.AddFirst(node);
			return this;
		}
	}
}
