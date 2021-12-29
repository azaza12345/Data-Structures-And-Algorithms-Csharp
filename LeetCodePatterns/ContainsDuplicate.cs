using System.Collections.Generic;
using System.IO;

namespace LeetCodePatterns
{
    public class ContainsDuplicate
    {
        public bool Solution(int[] nums)
        {
            var hashSet = new HashSet<int>();
            
            foreach (var num in nums)
            {
                if (hashSet.Contains(num))
                    return true;
                hashSet.Add(num);
            }


            return false;
        }
    }
}