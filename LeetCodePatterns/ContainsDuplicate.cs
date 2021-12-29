using System.Collections.Generic;

namespace LeetCodePatterns
{
    public class ContainsDuplicate
    {
        public bool Solution(int[] nums)
        {
            HashSet<int> hashSet = new HashSet<int>(nums);

            return hashSet.Count != nums.Length;
        }
    }
}