using System.Collections.Generic;

namespace TDDArg
{
    public class PascalsTriangle
    {
        public IList<IList<int>> Generate(int numRows)
        {
            List<IList<int>> result = new List<IList<int>>();

            List<int> preList = new List<int>();
            for (int i = 1; i <= numRows; i++)
            {
                if (i == 1)
                {
                    var list = preList = new List<int>() { 1 };
                    result.Add(list);
                }
                else
                {
                    List<int> list = new List<int>() { 1 };
                    for (int j = 2; j <= i; j++)
                    {
                        if (j == i)
                        {
                            list.Add(1);
                        }
                        else
                        {
                            list.Add(preList[j - 1] + preList[j - 2]);
                        }
                    }
                    preList = list;
                    result.Add(list);
                }
            }

            return result;
        }
    }
}