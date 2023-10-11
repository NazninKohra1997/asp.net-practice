using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuubleSort_and_Delegate
{
    public class Sort
    {
        public delegate bool Compare(int a,int b); 
        public int[] BubbleSort(int[] arr,Compare compare)
        {
            bool flag = true;
            int temp;
            for(int i = 0;i< arr.Length;i++)
            {
                flag = false;
                for(int j = i+1; j< arr.Length; j++)
                {
                    if (compare(arr[i],arr[j]))
                    {
                       
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                        flag = true;
                    }
                }
            }
            return arr;
        }
    }
}
