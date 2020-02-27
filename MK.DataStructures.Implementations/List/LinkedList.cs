using System;
using System.Collections.Generic;
using System.Linq;

namespace MK.DataStructures.Implementations.List
{
    public class LinkedList<T> : ILinkedList<T>
    {
        public INode<T> Head { get; set; }

        public INode<T> Tail { get; set; }

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
        public ILinkedList<T> AddToFront(INode<T> node)
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
        public ILinkedList<T> AddToEnd(INode<T> node)
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

        public ILinkedList<T> Add(INode<T> node, int position)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Removes first item from the list
        /// </summary>
        /// <returns></returns>
        public ILinkedList<T> RemoveFromFront()
        {
            if (this.Count() == 0)
                return null;

            var nextHeadNode = this.Head.Next;

            //If list contains only one node
            if(nextHeadNode == null)
            {
                this.Head = null;
                this.Tail = null;
            }
            else
            {
                this.Head = this.Head.Next;
            }
            return this;
        }

        /// <summary>
        /// Removes Last item from the list
        /// </summary>
        /// <returns></returns>
        public ILinkedList<T> RemoveFromEnd()
        {
            var listCount = this.Count();
            if (listCount == 0)
                return null;

            var lastButOneNode = this.getNode(listCount - 1);
            lastButOneNode.Next = null;
            this.Tail = lastButOneNode;

            return this;
        }

        public ILinkedList<T> Remove(int position)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns all the nodes in the list
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T> Enumerate()
        {
            var node = this.Head;
            while (node != null)
            {
                yield return node.Data;
                node = node.Next;
            }
        }

        /// <summary>
        /// Gets node based on the position
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        private INode<T> getNode(int position)
        {
            //If invalid position is provided
            if (position < 0 || position > this.Count())
                return null;

            var node = this.Head;
            var count = 0;
            INode<T> selectedNode = null;

            while (node != null)
            {
                count++;
                if (count == position)
                {
                    selectedNode = node;
                }
                node = node.Next;
            }
            return selectedNode;
        }
    }
}
