using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Codewars._5kyu
{
    public class SumSquaredDivisors
    {
        public static string listSquared(long m, long n)
        {
            var list = new List<string>();
            string result = "[";
            long value = 0;

            while (m < n)
            {
                var i = m;
                for (var a = 1; a <= i; a++)
                {
                    if (i % a == 0) value += a*a;
                }

                if (IsSquare((int)value))
                {
                    list.Add($"[{m}, {value}]");
                }
                value = 0;
                m++;
            }

            foreach (var pair in list)
            {
                result += pair;
                if (pair != list.Last())
                {
                    result += ", ";
                }
            }
            return result + "]";
        }
        
        private static bool IsSquare(int num)
        {
            return Math.Sqrt(num) % 1 == 0;
        }
    }
}