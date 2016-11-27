namespace TDDArg
{
    public class RegularExpressionMatching
    {
        public static bool IsMatch(string s, string p)
        {
            if (p.IndexOf('.') == -1 && p.IndexOf('*') == -1)
            {
                return s == p;
            }
            else if (p.IndexOf('*') == -1)
            {
                if (s.Length != p.Length)
                {
                    return false;
                }

                var sArr = s.ToCharArray();
                var pArr = p.ToCharArray();
                for (int i = 0; i < s.Length; i++)
                {
                    if (pArr[i] != '.' && sArr[i] != pArr[i])
                    {
                        return false;
                    }
                }

                return true;
            }
            else
            {
                int indexS = 0;
                for (int indexP = 0; indexP < p.ToCharArray().Length; indexP++)
                {
                    var pChar = p[indexP];

                    if (pChar == '.')
                    {
                        indexS++;
                    }
                    else if (pChar != '*')
                    {
                        if (indexS >= s.Length || pChar != s[indexS])
                        {
                            return false;
                        }

                        indexS++;
                    }
                    else
                    {
                        if (indexP != p.Length - 1)
                        {
                            var nextChar = p[indexP + 1];
                            while (indexS < s.Length - 1 && s[indexS] != nextChar)
                            {
                                indexS++;
                            }

                            if (indexS == s.Length - 1)
                            {
                                return true;
                            }
                        }
                        else
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }
    }
}