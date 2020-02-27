using System;
using System.Collections.Generic;
using System.Text;

namespace MK.DataStructures.Implementations
{
    public interface INode<T>
    {
        T Data { get; set; }
        INode<T> Next { get; set; }
    }
}
