using System;

namespace Algorithms.BaseAlgorithms
{
    public class BubbleSort<T> : AlgorithmBase<T> where T: IComparable
    {
        public override void Sort()
        {
            var count = Items.Count;

            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count - 1 - i; j++)
                {
                    var a = Items[j];
                    var b = Items[j + 1];
                    if (a.CompareTo(b) == 1)
                    {
                        Swap(j, j+1);
                    }
                }
            }
        }
    }
}