
using MK.DataStructures.Implementations.DoublyLinkedList;
using MK.DataStructures.Implementations.List;

namespace MK.DataStructures.Implementations
{
    public static class Extensions
    {
        public static int Count<T>(this ILinkedList<T> list)
        {
            if ((list == null) && (list.Head == null)) return 0;

            int count = 0;
            var node = list.Head;

            while (node != null)
            {
                count++;
                node = node.Next;
            }
            return count;
        }

        public static int Count<T>(this IDoublyLinkedList<T> list)
        {
            if ((list == null) && (list.Head == null)) return 0;

            int count = 0;
            var node = list.Head;

            while (node != null)
            {
                count++;
                node = node.Next;
            }
            return count;
        }
    }
}
