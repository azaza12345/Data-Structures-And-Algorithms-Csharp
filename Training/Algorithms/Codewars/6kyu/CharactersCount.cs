using System.Collections.Generic;

namespace Code_Wars_Train._6kyu
{
    public class CharactersCount
    {
        public static Dictionary<char, int> Count(string str)
        {
            var dictionary = new Dictionary<char, int>();
            var arr = str.Split();
            foreach (var symbol in str)
            {
                if (dictionary.ContainsKey(symbol))
                    dictionary[symbol]++;
                else
                    dictionary.Add(symbol, 1);
            }

            return dictionary;
        }
    }
}