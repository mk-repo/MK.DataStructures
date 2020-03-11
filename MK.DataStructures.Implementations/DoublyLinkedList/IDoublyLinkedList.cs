using System;
using System.Collections.Generic;
using System.Text;

namespace MK.DataStructures.Implementations.DoublyLinkedList
{
    public interface IDoublyLinkedList<T>
    {
        INode<T> Head { get; }

        INode<T> Tail { get; }

        IDoublyLinkedList<T> AddFirst(INode<T> node);

        IDoublyLinkedList<T> AddLast(INode<T> node);

        IDoublyLinkedList<T> Add(INode<T> node, int position);

        IDoublyLinkedList<T> RemoveFirst();

        IDoublyLinkedList<T> RemoveLast();

        IDoublyLinkedList<T> Remove(int position);

        IEnumerable<T> Enumerate();
    }
}
