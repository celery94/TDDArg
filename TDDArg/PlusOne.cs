using System.Linq;

namespace TDDArg
{
    public class PlusOne
    {
        public static int[] GetPlusOne(int[] digits)
        {
            bool plusOne = true;
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (plusOne)
                {
                    if (digits[i] + 1 == 10)
                    {
                        digits[i] = 0;
                    }
                    else
                    {
                        digits[i]++;
                        plusOne = false;
                        break;
                    }
                }
            }

            if (plusOne)
            {
                return new[] { 1 }.Concat(digits).ToArray();
            }

            return digits;
        }
    }
}