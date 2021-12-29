using System;
using System.Collections.Generic;
using System.Linq;

namespace Code_Wars_Train._6kyu
{
    public static class CaseChanger
    {
        public static string CamelCase(this string str)
        {
            List<char> list = str.Trim().ToList();
            var result = "";

            for (int i = 0; i < list.Count; i++)
            {
                list[0] = char.ToUpper(list[0]);
                if (list[i] == ' ')
                {
                    list[i + 1] = char.ToUpper(list[i + 1]);
                    continue;
                    // list.Remove(list[i]);
                    // if (i != list.Count)
                    //     list[i] = char.ToUpper(list[i]);
                }
                result += list[i];
            }

            return result;
        }
    }
}