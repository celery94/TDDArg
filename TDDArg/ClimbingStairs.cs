namespace TDDArg
{
    public class ClimbingStairs
    {
        public static int ClimbStairs(int n)
        {
            int a = 1, b = 2;

            if (n == 1) return a;
            if (n == 2) return b;

            for (int i = 3; i <= n; i++)
            {
                int c = a + b;
                a = b;
                b = c;
            }

            return b;
        }
    }
}