namespace TDDArg
{
    public class ImplementStrStr
    {
        public static int StrStr(string haystack, string needle)
        {
            if (string.IsNullOrEmpty(needle)) return 0;

            for (int i = 0; i < haystack.Length; i++)
            {
                for (int j = 0; j < needle.Length; j++)
                {
                    if (i + j >= haystack.Length)
                    {
                        return -1;
                    }

                    if (haystack[i + j] != needle[j])
                    {
                        break;
                    }
                    else if (j == needle.Length - 1)
                    {
                        return i;
                    }
                }
            }

            return -1;
        }
    }
}