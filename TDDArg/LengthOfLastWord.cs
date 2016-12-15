using System;
namespace TDDArg
{
	public class LengthOfLastWord
	{
		public static int FindLengthOfLastWord(string s)
		{
			int result = 0;
			s = s.TrimEnd();
			if (s.LastIndexOf(' ') != -1)
			{
				result = s.Substring(s.LastIndexOf(' ') + 1).Length;
			}
			else
			{
				result = s.Length;
			}

			return result;
		}
	}
}
