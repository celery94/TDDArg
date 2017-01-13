namespace TDDArg
{
    public class ClimbingStairs
    {
        public static int ClimbStairs(int n)
        {
            int count = 0;
            Climb(n, 0, ref count);

            return count;
        }

        public static void Climb(int n, int step, ref int count)
        {
            n -= step;

            if (n == 0) count++;

            if (n < 0) return;

            Climb(n, 1, ref count);

            Climb(n, 2, ref count);
        }
    }
}