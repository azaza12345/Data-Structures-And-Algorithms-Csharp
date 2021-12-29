using System;
using System.Linq.Expressions;

namespace Code_Wars_Train._5kyu
{
    public class Cipher
    {
        public static string Rot13(string message)
        {
            var alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            string result = "";
            bool shouldBeUpperCase = false;
            
            for (int i = 0; i < message.Length; i++)
            {
                if (char.IsUpper(message[i]))
                {
                    shouldBeUpperCase = true;
                }
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (alphabet[j] == char.ToLower(message[i]))
                    {
                        if (shouldBeUpperCase)
                        {
                            if (j + 13 <= alphabet.Length)
                                result += char.ToUpper(alphabet[j + 13]);
                            else
                                result += char.ToUpper(alphabet[j - 13]);
                        }
                        else
                        {
                            if (j + 13 <= alphabet.Length)
                                result += alphabet[j + 13];
                            else
                                result += alphabet[j - 13];
                        }
                    }
                }

                shouldBeUpperCase = false;
            }

            return result;
        }
    }
}