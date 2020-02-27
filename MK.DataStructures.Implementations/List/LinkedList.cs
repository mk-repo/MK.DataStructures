using System;
using System.Collections.Generic;
using System.Text;

namespace MK.DataStructures.Implementations.List
{
    public class LinkedList<T> : ILinkedList<T>
    {
        public Node<T> Head { get; set; }

        public Node<T> Tail { get; set; }

        public LinkedList()
        {
            this.Head = null;
            this.Tail = null;
        }

        /// <summary>
        /// Add's a node at the top of the list
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public ILinkedList<T> AddToFront(Node<T> node)
        {
            if (node == null)
                return this;

            var _temp = this.Head;
            this.Head = node;
            this.Head.Next = _temp;

            if (this.Count() == 1)
            {
                this.Tail = this.Head;
            }
            return this;
        }

        /// <summary>
        /// Add's a node at the end of the list
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public ILinkedList<T> AddToEnd(Node<T> node)
        {
            if (node == null)
                return this;

            if (this.Count() == 0)
            {
                this.Head = node;
                this.Tail = node;
            }
            else
            {
                this.Tail.Next = node;
                this.Tail = node;
            }
            return this;
        }

        public ILinkedList<T> Add(Node<T> node, int position)
        {
            throw new NotImplementedException();
        }

        public ILinkedList<T> RemoveFromFront(Node<T> node)
        {
            throw new NotImplementedException();
        }

        public ILinkedList<T> RemoveFromEnd(Node<T> node)
        {
            throw new NotImplementedException();
        }

        public ILinkedList<T> Remove(Node<T> node, int position)
        {
            throw new NotImplementedException();
        }

        public ILinkedList<T> Enumerate()
        {
            throw new NotImplementedException();
        }
    }
}
