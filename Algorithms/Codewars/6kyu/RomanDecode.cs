using System;
using System.Collections.Generic;
using System.Linq;

namespace Code_Wars_Train._6kyu
{
    public class RomanDecode
    {
        private static readonly Dictionary<char, int> literals = new Dictionary<char, int>
        {
          {'I', 1},
          {'V', 5},
          {'X', 10},
          {'L', 50},
          {'C', 100},
          {'D', 500},
          {'M', 1000}
        };
        
          public static int Solution(string roman)
          {
            int result = 0;
            int max = 0;
        
            foreach (var c in roman.Reverse())
            {
              int value = literals[c];
        
              if (value < max)
              {
                result -= value;
              }
              else
              {
                result += value;
                max = value;
              }
            }
            return result;
          }
    }
}