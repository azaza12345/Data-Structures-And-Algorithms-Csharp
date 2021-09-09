using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.BaseAlgorithms
{
    public class CoctailSort<T> : AlgorithmBase<T> where T: IComparable
    {
        public override void Sort()
        {
            int left = 0;
            int right = Items.Count - 1;

            while(left < right)
            {
                for (int i = left; i < right; i++)
                {
                    var a = Items[i];
                    var b = Items[i + 1];

                    if (a.CompareTo(b) == 1)
                    {
                        Swap(i, i + 1);
                    }
                }
                right--;
                for (int i = right; i > left; i--)
                {
                    var a = Items[i];
                    var b = Items[i - 1];

                    if (a.CompareTo(b) == -1)
                    {
                        Swap(i, i - 1);
                    }
                }
                left++;
            }
            
        }
    }
}
