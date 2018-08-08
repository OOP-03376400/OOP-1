using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labrab8
{
    interface Interface<T>
    {
        void Add(T element);
        void Remove(T element);
        void Show();
    }
}