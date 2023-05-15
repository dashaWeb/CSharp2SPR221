using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_Generic_class_Stack
{
    interface IStack<T> //:IEnumerable<T>
    {
        void Push(T elem);
        void Pop();
        T Peek();
        int Count { get; }
    }
}
