using MK.DataStructures.Implementations;
using System;

namespace MK.DataStructures.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var _nodeChain = new NodeChain();
            var _integerNodeChain = _nodeChain.BuildIntegerNodeChain();

            var _program = new Program();
            _program.PrintNodeChain(_integerNodeChain);
        }

        void PrintNodeChain<T>(Node<T> node)
        {
            if (node == null) return;

            Console.WriteLine($"Node Value: {node.Data}");
            PrintNodeChain<T>(node.Next);
        }
    }
}
