using System;
using System.Collections.Generic;
using System.Text;

namespace MK.DataStructures.Implementations.List
{
    public interface ILinkedList<T>
    {
        INode<T> Head { get; set; }

        INode<T> Tail { get; set; }

        ILinkedList<T> AddToFront(INode<T> node);

        ILinkedList<T> AddToEnd(INode<T> node);

        ILinkedList<T> Add(INode<T> node, int position);

        ILinkedList<T> RemoveFromFront();

        ILinkedList<T> RemoveFromEnd();

        ILinkedList<T> Remove(int position);

        IEnumerable<T> Enumerate();

    }
}
