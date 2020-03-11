using MK.DataStructures.Implementations;
using MK.DataStructures.Implementations.DoublyLinkedList;
using MK.DataStructures.Implementations.List;
using System;
using System.Linq;

namespace MK.DataStructures.Client
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Node Chain");
            var _nodeChain = new NodeChain();
            var _integerNodeChain = _nodeChain.BuildIntegerNodeChain();

            var _program = new Program();
            _program.PrintNodeChain(_integerNodeChain);

            #region LinkedList
            //Console.WriteLine("Build List");
            //var _node = new Node<int>(5);
            //var _node1 = new Node<int>(7);
            //var _node2 = new Node<int>(10);
            //var _node3 = new Node<int>(15);
            //var _node4 = new Node<int>(20);


            //var _linkedList = new LinkedList<int>();
            //_program.AddFirstItemToList(_linkedList, _node);
            //_program.AddFirstItemToList(_linkedList, _node1);
            //_program.AddFirstItemToList(_linkedList, _node2);

            //_program.AddLastItemToList(_linkedList, _node3);

            //_program.AddFirstItemToList(_linkedList, _node4);

            //_program.PrintListItems(_linkedList);

            //Console.WriteLine("Removing First Item From List");
            //_program.RemoveFirstItemFromList(_linkedList);

            //_program.PrintListItems(_linkedList);

            //Console.WriteLine("Removing Last Item From List");
            //_program.RemoveLastItemFromList(_linkedList);

            //_program.PrintListItems(_linkedList);

            //Console.WriteLine("Removing item base on position. Position: 2");
            //_program.RemoveItemFromList(_linkedList, 2);

            //_program.PrintListItems(_linkedList);

            //Console.WriteLine("Adding item base on position. Position: 2");
            //var _node5 = new Node<int>(25);
            //_program.AddItemsToList(_linkedList, _node5, 2);

            //_program.PrintListItems(_linkedList);
            #endregion

            #region DoublyLinkedList
            Console.WriteLine("Build Doubly Linked List");
            var _dllnode = new Node<int>(5);
            var _dllnode1 = new Node<int>(10);
            var _dllnode2 = new Node<int>(15);

            var _doublyLinkedList = new DoublyLinkedList<int>();
            _program.AddFirstItemToList(_doublyLinkedList, _dllnode);
            _program.AddFirstItemToList(_doublyLinkedList, _dllnode1);
            _program.AddFirstItemToList(_doublyLinkedList, _dllnode2);

            _program.PrintListItems(_doublyLinkedList);

            #endregion
        }

        #region LinkedListOperations
        void PrintNodeChain<T>(INode<T> node)
        {
            if (node == null) return;

            Console.WriteLine($"Node Value: {node.Data}");
            PrintNodeChain(node.Next);
        }

        void AddFirstItemToList<T>(ILinkedList<T> linkedList, INode<T> node)
        {
            linkedList.AddFirst(node);

            Console.WriteLine("List Length :" + linkedList.Count());
        }

        void AddLastItemToList<T>(ILinkedList<T> linkedList, INode<T> node)
        {
            linkedList.AddLast(node);

            Console.WriteLine("List Length :" + linkedList.Count());
        }

        void AddItemsToList<T>(ILinkedList<T> linkedList, INode<T> node, int position)
        {
            linkedList.Add(node, position);
            Console.WriteLine("List Length :" + linkedList.Count());
            Console.WriteLine("First Node:" + linkedList.Head.Data);
            Console.WriteLine("Last Node:" + linkedList.Tail.Data);
        }

        void RemoveFirstItemFromList<T>(ILinkedList<T> linkedList)
        {
            linkedList.RemoveFirst();
            Console.WriteLine("List Length :" + linkedList.Count());
            Console.WriteLine("First Node:" + linkedList.Head.Data);
            Console.WriteLine("Last Node:" + linkedList.Tail.Data);
        }

        void RemoveLastItemFromList<T>(ILinkedList<T> linkedList)
        {
            linkedList.RemoveLast();
            Console.WriteLine("List Length :" + linkedList.Count());
            Console.WriteLine("First Node:" + linkedList.Head.Data);
            Console.WriteLine("Last Node:" + linkedList.Tail.Data);
        }

        void RemoveItemFromList<T>(ILinkedList<T> linkedList, int position)
        {
            linkedList.Remove(position);
            Console.WriteLine("List Length :" + linkedList.Count());
            Console.WriteLine("First Node:" + linkedList.Head.Data);
            Console.WriteLine("Last Node:" + linkedList.Tail.Data);
        }

        void PrintListItems<T>(ILinkedList<T> linkedList)
        {
            linkedList.Enumerate().ToList().ForEach(node =>
            {
                Console.WriteLine(node);
            });
        }
        #endregion

        #region DoublyLinkedListOperations

        void AddFirstItemToList<T>(IDoublyLinkedList<T> doublyLinkedList, INode<T> node)
        {
            doublyLinkedList.AddFirst(node);

            Console.WriteLine("List Length :" + doublyLinkedList.Count());
        }

        void PrintListItems<T>(IDoublyLinkedList<T> doublyLinkedList)
        {
            doublyLinkedList.Enumerate().ToList().ForEach(node =>
            {
                Console.WriteLine(node);
            });
        }
        #endregion
    }
}
