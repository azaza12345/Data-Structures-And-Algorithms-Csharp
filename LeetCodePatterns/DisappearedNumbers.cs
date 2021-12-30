using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodePatterns
{
    public static class DisappearedNumbers
    {
        public static IList<int> Solution(int[] nums)
        {
            var result = new List<int>();
            var max = nums.Length;
            
            for (int i = 1; i <= max; i++)
            {
                if(nums.Contains(i))
                    continue;
                
                result.Add(i);
            }
            
            return result;
        }
    }
}