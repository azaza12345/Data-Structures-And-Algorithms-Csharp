namespace Code_Wars_Train._6kyu
{
    public class BallBounce
    {
        public static int BouncingBall(double h, double bounce, double window)
        {
            if (h < 0) return -1;
            if (bounce > 1 && bounce < 0) return -1;
            if (window > h) return -1;

            int result = -1;
            while (h > window)
            {
                h *= bounce;
                result += 2;
            }
            return result;
        }
    }
}