using MK.DataStructures.Implementations.Base;
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

        public IBaseList<T> Add(INode<T> node, int position)
        {
            if (node == null)
                throw new ArgumentNullException("Invalid Node");

            if (position <= 0 || position > this.Count() + 1)
                throw new ArgumentOutOfRangeException("Invalid Position");

            var index = 1;
            var _currentItem = Head;
            while(index <= position)
            {
                if(index == position)
                {
                    if(_currentItem == null)
                    {
                        Head = Tail = node;
                    }
                    else
                    {
                        var _indexedNextItem = _currentItem.Next;
                        node.Previous = _currentItem;
                        node.Next = _indexedNextItem;
                        _currentItem.Next = node;
                    }
                    break;
                }
                _currentItem = _currentItem.Next;
                index++;
            }
            return this;
        }

        public IBaseList<T> AddFirst(INode<T> node)
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

        public IBaseList<T> AddLast(INode<T> node)
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

        public IBaseList<T> Remove(int position)
        {
            if (position <= 0 || position > this.Count())
                throw new ArgumentOutOfRangeException("Invalid Position");

            var index = 1;
            var _currentItem = Head;
            while (index <= position)
            {
                if (index == position)
                {
                    if (_currentItem == null)
                    {
                        Head = Tail = null;
                    }
                    else
                    {
                        var _indexedPreviousItem = _currentItem.Previous;
                        var _indexedNextItem = _currentItem.Next;

                        _indexedPreviousItem.Next = _indexedNextItem;
                    }
                    break;
                }
                _currentItem = _currentItem.Next;
                index++;
            }

            return this;
        }

        public IBaseList<T> RemoveFirst()
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

        public IBaseList<T> RemoveLast()
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

        /// <summary>
        /// Clears Doubly Linked List
        /// </summary>
        public void Clear()
        {
            this.Head = null;
            this.Tail = null;
        }
    }
}
