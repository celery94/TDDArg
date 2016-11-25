using System.Linq;
using System.Text;

namespace TDDArg
{
    public class ZigZagConversion
    {
        public static string Convert(string text, int numRows)
        {
            if (numRows == 1) return text;

            StringBuilder result = new StringBuilder();

            for (int row = 0; row < numRows; row++)
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (row % 2 == 0)
                    {
                        if ((i - row) % (numRows + numRows / 2) == 0)
                        {
                            result.Append(text[i]);
                        }
                    }
                    else
                    {
                        if (row == numRows - 1)
                        {
                            if ((i - row) % (numRows + numRows / 2) == 0)
                            {
                                result.Append(text[i]);
                            }

                            if ((i - row - numRows / 2) % (numRows + numRows / 2) == 0)
                            {
                                result.Append(text[i]);
                            }
                        }
                        else
                        {
                            if ((i - row) % (numRows - 1) == 0)
                            {
                                result.Append(text[i]);
                            }
                        }
                    }
                }
            }

            return result.ToString();
        }
    }
}