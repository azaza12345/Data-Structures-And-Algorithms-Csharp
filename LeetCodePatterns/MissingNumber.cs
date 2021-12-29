using System.Linq;

namespace LeetCodePatterns
{
    public class MissingNumber
    {
        public int Solution(int[] nums)
        {
            var count = nums.Length;
            var sum = count * (count+1) / 2;

            return sum - nums.Sum();
        }
    }
}