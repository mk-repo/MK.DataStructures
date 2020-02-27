namespace MK.DataStructures.Implementations
{
    public class NodeChain
    {
        public INode<int> BuildIntegerNodeChain()
        {
            var firstNode = new Node<int> { Data = 3 };
            var middleNode = new Node<int> { Data = 5 };
            var lastNode = new Node<int> { Data = 7 };

            firstNode.Next = middleNode;
            middleNode.Next = lastNode;

            return firstNode;
        }
    }
}
