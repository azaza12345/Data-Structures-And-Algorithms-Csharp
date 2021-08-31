namespace Code_Wars_Train._6kyu
{
    public static class BitCounting
    {
        public static int CountBits(int n)
        {
            int result = 0;
            while (n > 0)
            {
                if(n % 2 == 1)
                    result++;
                n /= 2;
            }

            return result;
        }
    }
}