using System;
using System.Collections.Generic;
using System.Text;

namespace MK.DataStructures.Implementations.DoublyLinkedList
{
    public class DoublyLinkedList<T> : IDoublyLinkedList<T>
    {
        public INode<T> Head { get; set; }
        public INode<T> Tail { get; set; }

        public DoublyLinkedList()
        {

        }

        public IDoublyLinkedList<T> Add(INode<T> node, int position)
        {
            throw new NotImplementedException();
        }

        public IDoublyLinkedList<T> AddFirst(INode<T> node)
        {
            if (node == null)
                return this;

            var _temp = Head;
            Head = node;
            Head.Next = _temp;

            if (this.Count() == 1)
            {
                Tail = Head;
            }
            return this;
        }

        public IDoublyLinkedList<T> AddLast(INode<T> node)
        {
            if (node == null)
                return this;

            if (this.Count() == 0)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                Tail.Next = node;
                Tail = node;
            }
            return this;
        }

        public IEnumerable<T> Enumerate()
        {
            throw new NotImplementedException();
        }

        public IDoublyLinkedList<T> Remove(int position)
        {
            throw new NotImplementedException();
        }

        public IDoublyLinkedList<T> RemoveFirst()
        {
            if (this.Count() == 0)
                return null;

            //If list contains only one node
            if (Head.Next == null)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                Head = Head.Next;
            }
            return this;
        }

        public IDoublyLinkedList<T> RemoveLast()
        {
            throw new NotImplementedException();
        }
    }
}
