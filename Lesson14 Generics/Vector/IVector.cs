using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArray
{
    interface IVector<T>
    {
        int Lenght { get; }
        void Add(T obj);
        void Add(T obj, int index);     
        void DeleteElement(int index);
        void ClearAll();
        string Search(T Entry);
        string ToString();
    }
}
