using System.Text;

namespace TDDArg
{
    public class MultiplyStrings
    {
        public static string Multiply(string num1, string num2)
        {
            var l1 = num1.Length;
            var l2 = num2.Length;

            int[] array = new int[l1 + l2];

            for (int i = l1 - 1; i >= 0; i--)
            {
                for (int j = l2 - 1; j >= 0; j--)
                {
                    int c1 = num1[i] - '0';
                    int c2 = num2[j] - '0';

                    var result = c1 * c2;

                    array[i + j + 1] += result % 10;
                    if (array[i + j + 1] >= 10)
                    {
                        array[i + j]++;
                        array[i + j + 1] = array[i + j + 1] % 10;
                    }

                    array[i + j] += result / 10;
                    if (array[i + j] >= 10)
                    {
                        array[i + j -1]++;
                        array[i + j] = array[i + j] % 10;
                    }
                }
            }

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < array.Length; i++)
            {
                sb.Append(array[i]);
            }

            var str = sb.ToString().TrimStart('0');
            return string.IsNullOrEmpty(str) ? "0" : str;
        }
    }
}