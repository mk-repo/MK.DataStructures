using System;
using System.Collections.Generic;
using System.Text;

namespace MK.DataStructures.Implementations.List
{
    public interface ILinkedList<T>
    {
        Node<T> Head { get; set; }

        Node<T> Tail { get; set; }

        ILinkedList<T> AddToFront(Node<T> node);

        ILinkedList<T> AddToEnd(Node<T> node);

        ILinkedList<T> Add(Node<T> node, int position);

        ILinkedList<T> RemoveFromFront(Node<T> node);

        ILinkedList<T> RemoveFromEnd(Node<T> node);

        ILinkedList<T> Remove(Node<T> node, int position);

        ILinkedList<T> Enumerate();

    }
}
