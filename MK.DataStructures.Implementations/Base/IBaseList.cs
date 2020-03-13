using System;
using System.Collections.Generic;
using System.Text;

namespace MK.DataStructures.Implementations.Base
{
    public interface IBaseList<T>
    {
        INode<T> Head { get; }

        INode<T> Tail { get; }

        IBaseList<T> AddFirst(INode<T> node);

        IBaseList<T> AddLast(INode<T> node);

        IBaseList<T> Add(INode<T> node, int position);

        IBaseList<T> RemoveFirst();

        IBaseList<T> RemoveLast();

        IBaseList<T> Remove(int position);

        IEnumerable<T> Enumerate();

        void Clear();
    }
}
