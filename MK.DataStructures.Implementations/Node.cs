namespace MK.DataStructures.Implementations
{
    public class Node<T> : INode<T>
    {
        public INode<T> Previous { get; set; }

        public T Data { get; set; }

        public INode<T> Next { get; set; }

        public Node(T data)
        {
            Data = data;
        }
    }
}
