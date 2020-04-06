namespace MK.DataStructures.Implementations.Stack
{
	public interface IStack<T>
	{
		IStack<T> Push(INode<T> node);

		IStack<T> Pop();

		void Clear();
	}
}
