namespace MK.DataStructures.Implementations
{
    public class NodeChain
    {
        public INode<int> BuildIntegerNodeChain()
        {
            var firstNode = new Node<int>(3);
            var middleNode = new Node<int>(5);
            var lastNode = new Node<int>(7);

            firstNode.Next = middleNode;
            middleNode.Next = lastNode;

            return firstNode;
        }
    }
}
