using System;
using System.Collections;

namespace Algorithms.Tasks
{
    public class RLE
    {
        public static string Solution(string str)
        {
            string result = "";
            char symbol = str[0];
            int position = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != symbol)
                {
                    int count = i - position;
                    result += PackResult(symbol, count);
                    position = i;
                    symbol = str[i];
                }
            }
            int countLast = str.Length - position;
            result += PackResult(symbol, countLast);
            return result;
        }
        private static string PackResult(char symbol, int count)
        {
            string result = "";
            result += symbol;
            if (count > 1)
                result += count;

            return result;
        }
    }
}