using System;
using System.Collections.Generic;
using System.Text;

namespace MK.DataStructures.Implementations
{
    public interface INode<T>
    {
        INode<T> Previous { get; set; }

        T Data { get; set; }

        INode<T> Next { get; set; }
    }
}
