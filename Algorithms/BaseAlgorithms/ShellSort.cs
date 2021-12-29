using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.BaseAlgorithms
{
    public class ShellSort<T> : AlgorithmBase<T> where T: IComparable
    {
        public override void Sort()
        {
            var step = Items.Count / 2;

            while(step > 0)
            {
                for(int i = step; i < Items.Count; i++)
                {
                    int j = i;
                    var item = Items[j];
                    while(j >= step && item.CompareTo(Items[j-step]) == -1)
                    {
                        Items[j] = Items[j - step];
                        j -= step;
                    }
                    Items[j] = item;
                }
                step /= 2;
            }
        }
    }
}
