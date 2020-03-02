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
        public ILinkedList<T> AddFirst(INode<T> node)
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
        public ILinkedList<T> AddLast(INode<T> node)
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

        /// <summary>
        /// Add's item to list at a given position
        /// </summary>
        /// <param name="node"></param>
        /// <param name="position"></param>
        /// <returns></returns>
        public ILinkedList<T> Add(INode<T> node, int position)
        {
            if (node == null) return null;

            var listLength = this.Count();
            var count = 0;
            //If invalid position is provided
            //Count + 1: This is the case to add item at the end of the list
            if (position < 0 || position > listLength)
                return null;

            var item = this.Head;
            INode<T> previousNode = null;

            //Adding an item when list is empty
            if (item == null)
            {
                this.Head = node;
                this.Tail = node;
            }

            //Add at the top of the list
            if (position == 1)
            {
                return this.AddFirst(node);
            }
            //Add at the end of the list
            else if (position == listLength)
            {
                return this.AddLast(node);
            }
            else
            {
                while (count < listLength)
                {
                    count++;
                    if (count + 1 == position)
                    {
                        previousNode = item;
                    }
                    item = item?.Next;
                }

                var temp = previousNode.Next;
                previousNode.Next = node;
                node.Next = temp;

                return this;
            }
        }

        /// <summary>
        /// Removes first item from the list
        /// </summary>
        /// <returns></returns>
        public ILinkedList<T> RemoveFirst()
        {
            if (this.Count() == 0)
                return null;

            var nextHeadNode = this.Head.Next;

            //If list contains only one node
            if (nextHeadNode == null)
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
        public ILinkedList<T> RemoveLast()
        {
            var listCount = this.Count();
            if (listCount == 0)
                return null;

            var lastButOneNode = this.getNode(listCount - 1);
            lastButOneNode.Next = null;
            this.Tail = lastButOneNode;

            return this;
        }

        /// <summary>
        /// Removes item from list based on position provided
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public ILinkedList<T> Remove(int position)
        {
            //If invalid position is provided
            if (position < 0 || position > this.Count())
                return null;

            var node = this.Head;
            var count = 0;
            INode<T> previousNode = null;
            INode<T> nextNode = null;

            while (node != null && count <= position + 1)
            {
                count++;
                //To identify previous node to the positioned node
                if (count + 1 == position)
                {
                    previousNode = node;
                }
                //To identify next node to the positioned node
                else if (count - 1 == position)
                {
                    nextNode = node;
                }
                node = node.Next;
            }

            previousNode.Next = nextNode;
            return this;
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
                    break;
                }
                node = node.Next;
            }
            return selectedNode;
        }
    }
}
