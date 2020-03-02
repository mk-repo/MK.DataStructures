using System;
using System.Collections.Generic;
using System.Text;

namespace MK.DataStructures.Implementations.List
{
	public interface ILinkedList<T>
	{
		INode<T> Head { get; }

		INode<T> Tail { get; }

        ILinkedList<T> AddFirst(INode<T> node);

        ILinkedList<T> AddLast(INode<T> node);

		ILinkedList<T> Add(INode<T> node, int position);

        ILinkedList<T> RemoveFirst();

        ILinkedList<T> RemoveLast();

		ILinkedList<T> Remove(int position);

		IEnumerable<T> Enumerate();

		void Clear();

	}
}
