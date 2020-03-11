using System;
using System.Collections.Generic;
using System.Text;

namespace MK.DataStructures.Implementations.DoublyLinkedList
{
    public class DoublyLinkedList<T> : IDoublyLinkedList<T>
    {
        public INode<T> Head { get; private set; }
        public INode<T> Tail { get; private set; }

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

            if(this.Any())
            {
                var _currentHead = Head;
                Head = node;
                Head.Next = _currentHead;
                _currentHead.Previous = Head;
            }
            else
            {
                Head = Tail = node;
            }
            return this;
        }

        public IDoublyLinkedList<T> AddLast(INode<T> node)
        {
            if (node == null)
                return this;

            if (this.Any())
            {
                var _currentLastNode = Tail;
                Tail = node;
                Tail.Previous = _currentLastNode;
                _currentLastNode.Next = Tail;
            }
            else
            {
                Head = Tail = node;
            }
            return this;
        }

        public IEnumerable<T> Enumerate()
        {
            var node = this.Head;
            while (node != null)
            {
                yield return node.Data;
                node = node.Next;
            }
        }

        public IDoublyLinkedList<T> Remove(int position)
        {
            throw new NotImplementedException();
        }

        public IDoublyLinkedList<T> RemoveFirst()
        {
            if (!this.Any())
                return null;

            //If list contains only one node
            if (Head.Next == null)
            {
                Head = Tail = null;
            }
            else
            {
                Head = Head.Next;
                Head.Previous = null;
            }
            return this;
        }

        public IDoublyLinkedList<T> RemoveLast()
        {
            if (!this.Any())
                return null;

            if(Tail.Previous == null)
            {
                Head = Tail = null;
            }
            else
            {
                Tail.Previous.Next = null;
                Tail = Tail.Previous;
            }

            return null;
        }
    }
}
