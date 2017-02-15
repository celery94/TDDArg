using System.Collections.Generic;

namespace TDDArg
{
    public class PascalsTriangleII
    {
        public IList<int> GetRow(int rowIndex)
        {
            List<int> result = new List<int>();
            for (int i = 0; i <= rowIndex; i++)
            {
                result.Add(1);
                for (int j = i / 2; j >= 1; j--)
                {
                    result[j] = result[j] + result[j - 1];
                }

                for (int j = i; j > i / 2; j--)
                {
                    result[j] = result[i - j];
                }
            }

            return result;
        }
    }
}