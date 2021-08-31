namespace Code_Wars_Train
{
    public class Parentheses
    {
        public static bool ValidParentheses(string input)
        {
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                    count++;
                if (input[i] == ')')
                    count--;
                if (count < 0) return false;
            }

            return count == 0;
        }
    }
}