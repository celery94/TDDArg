namespace TDDArg
{
    public class HammingDistance
    {
        public int FindHammingDistance(int x, int y)
        {
            var result = x ^ y;

            int count = 0;
            while (result > 0)
            {
                if (result % 2 == 1) count++;
                result = result >> 1;
            }

            return count;
        }
    }
}