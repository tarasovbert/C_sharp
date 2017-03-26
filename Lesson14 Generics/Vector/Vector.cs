using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArray
{
    public class Vector<T>: IVector<T>
    {
        T[] arr = new T[0];
        public int Lenght { get { return arr.Length; } }

        public Vector() {}
        public Vector(T element)
        {
            Add(element);
        }

        public void Add(T obj)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = obj;
        }

        public void Add(T obj, int index)
        {
            IndexChecker(index);
            Array.Resize(ref arr, arr.Length + 1);
            for (int i = arr.Length - 1; i > index; i--)
                arr[i] = arr[i - 1];
            arr[index] = obj;
        }

        private void IndexChecker(int index)
        {
            if (index < 0) throw new IndexOutOfRangeException("Index should be non-negative!");
            if (index >= arr.Length) throw new IndexOutOfRangeException("Index is out of range!");
        }

        public void DeleteElement(int index)
        {
            IndexChecker(index);
            for (int i = index; i < arr.Length - 1; i++)
                arr[i] = arr[i + 1];
            Array.Resize(ref arr, arr.Length - 1);
        }

        public void ClearAll()
        {
            Array.Resize(ref arr, 0);
        }

        public string Search(T Entry)
        {
            for (int i = 0; i < arr.Length; i++)
                if (arr[i].Equals(Entry))
                    return String.Format("Yes! Entry \"{0}\" is in the vector.", Entry);
            return String.Format("No! Entry \"{0}\" isn't in the vector.", Entry);
        }

        public static void Sort(ref Vector<T> vec)
        {
            Array.Sort(vec.arr);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < arr.Length; i++)
                sb.Append(arr[i] + Environment.NewLine);
            return sb.ToString();
        }
    }
}
