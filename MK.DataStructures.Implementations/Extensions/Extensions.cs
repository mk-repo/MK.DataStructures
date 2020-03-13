
using MK.DataStructures.Implementations.Base;
using MK.DataStructures.Implementations.DoublyLinkedList;
using MK.DataStructures.Implementations.List;

namespace MK.DataStructures.Implementations
{
    public static class Extensions
    {
        public static int Count<T>(this IBaseList<T> list)
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

        //public static int Count<T>(this IBaseList<T> list)
        //{
        //    if ((list == null) && (list.Head == null)) return 0;

        //    int count = 0;
        //    var node = list.Head;

        //    while (node != null)
        //    {
        //        count++;
        //        node = node.Next;
        //    }
        //    return count;
        //}

        public static bool Any<T>(this IBaseList<T> list)
        {
            if (list == null)
                return false;

            return list.Head != null;
        }
    }
}
