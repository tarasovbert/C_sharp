using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartArray
{
    public class SmartArray
    {
        private int indexLower;
        private int indexUpper;
        int[] array;

        public SmartArray(int indexLower, int indexUpper)
        {
            if (indexLower > indexUpper)
                throw new WrongIndecesException("Left index cannot be greater than right!");
            IndexLower = indexLower;
            IndexUpper = indexUpper;
            array = new int[indexUpper - indexLower + 1];
            for (int i = 0; i < array.Length; i++)
                array[i] = Randomer.Next(-100, 100);
        }

        public int IndexLower
        {
            get { return indexLower; }
            private set
            {
                indexLower = value;
            }
        }
        public int IndexUpper
        {
            get { return indexUpper; }
            private set
            {
                indexUpper = value;
            }
        }

        public int this[int index]
        {
            get
            {
                index -= indexLower;
                if (index >= 0 && index <= array.Length)
                    return array[index];
                else
                    throw new IndexOutOfRangeException("Get failed: out of range!");
            }
            set
            {
                index -= indexLower;
                if (index >= 0 && index <= array.Length)
                    array[index] = value;
                else
                    throw new IndexOutOfRangeException("Set failed: out of range!");
            }
        }  
        
        public int Length
        {
            get
            {
                return array.Length;
            }
        }     
    }
}
