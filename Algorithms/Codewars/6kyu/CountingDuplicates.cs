using System;
using System.Collections.Generic;
using System.Linq;

namespace Code_Wars_Train._6kyu
{
    public class CountingDuplicates
    {
        public static int DuplicateCount(string str)
        {
            HashSet<string> result = new HashSet<string>();
            HashSet<string> hashSet = new HashSet<string>();

            foreach (var symbol in str)
            {
                var s = symbol.ToString().ToLower();
                if (!hashSet.Add(s))
                    result.Add(s);
            }

            return result.Count;
        }
    }
}