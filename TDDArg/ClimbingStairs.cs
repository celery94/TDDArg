namespace TDDArg
{
    public class ClimbingStairs
    {
        public static int ClimbStairs(int n)
        {
            return Climb(n);
        }

        public static int Climb(int n)
        {
            if (n == 1) return 1;
            if (n == 2) return 2;

            return Climb(n - 1) + Climb(n - 2);
        }
    }
}