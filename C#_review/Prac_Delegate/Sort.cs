using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac_Delegate
{
    public class Sort<T>
    {
        public delegate bool Compare(T a, T b);
        public T[] BubbleSort(T[] arr, Compare compare)
        {
            T temp;
            for(int i = 0; i <arr.Length; i++)
            {
                for(int j=0; j<arr.Length; j++)
                {
                    if (compare(arr[i],arr[j]))
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }
    }
}
