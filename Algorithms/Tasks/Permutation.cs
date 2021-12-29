using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Tasks
{
    class Permutation
    {
        public static bool IsPermunation(int x, int y)
        {
            int[] numbers = new int[10];
            while(x > 0 || y > 0)
            {
                Console.Write(x % 10 + " ");
                numbers[x % 10]++;
                numbers[y % 10]--;
                y /= 10;
                x /= 10;
            }
            Console.WriteLine();
            //while (y > 0)
            //{
            //    Console.Write(y % 10 + " ");
            //}
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] != 0)
                    return false;
            }
            return true;
        }
    }
}
