namespace MK.DataStructures.Implementations
{
    public class Node<T> : INode<T>
    {
        public T Data { get; set; }
        public INode<T> Next { get; set; }
    }
}
