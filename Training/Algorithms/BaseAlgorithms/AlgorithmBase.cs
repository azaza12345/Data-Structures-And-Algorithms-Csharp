using System;
using System.Collections.Generic;

namespace Algorithms.BaseAlgorithms
{
    public class AlgorithmBase<T> where T: IComparable
    {
        public int SwapCount { get; private set; } = 0;
        public List<T> Items { get; set; } = new List<T>();

        protected void Swap(int positionA, int positionB)
        {
            if (positionA < Items.Count && positionB < Items.Count)
            {
                var temp = Items[positionB];
                Items[positionB] = Items[positionA];
                Items[positionA] = temp;

                SwapCount++;
            }
        }

        public virtual void Sort()
        {
            SwapCount = 0;
            Items.Sort();
        }
    }
}