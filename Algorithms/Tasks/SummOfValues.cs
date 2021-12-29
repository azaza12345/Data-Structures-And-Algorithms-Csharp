using System;
using System.Collections.Generic;

namespace Algorithms.Tasks
{
    public class SummOfValues
    {
        public static void Solution(int[] array, int number)
        {
            var set = new HashSet<int>();
            foreach (var item in array)
            {
                if (set.Contains(item - number))
                {
                    Console.WriteLine(item);
                    Console.WriteLine(item-number);
                }
                else
                {
                    set.Add(item);
                }
            }
        }
    }
}