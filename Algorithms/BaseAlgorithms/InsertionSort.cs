using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.BaseAlgorithms
{
    public class InsertionSort<T> : AlgorithmBase<T> where T : IComparable
    {
        public override void Sort()
        {
            for(int i = 1; i < Items.Count; i++)
            {
                var item = Items[i];
                var j = i;
                while (j > 0 && item.CompareTo(Items[j-1]) == -1)
                {
                    Items[j] = Items[j - 1];
                    j--;
                }
                Items[j] = item;
            }
        }
    }
}
