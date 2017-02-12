using System;
using System.Collections.Generic;

namespace TDDArg
{
	public class WordPattern
	{
		public static bool FindWordPattern(string pattern, string str)
		{
			var strArray = str.Split(' ');

			if (strArray.Length != pattern.Length) return false;

			Dictionary<string, char> dic = new Dictionary<string, char>();
			for (int i = 0; i < strArray.Length; i++)
			{
				if (dic.ContainsKey(strArray[i]))
				{
					if (pattern[i] != dic[strArray[i]]) return false;
				}
				else  if(dic.ContainsValue(pattern[i]))
				{
					return false;
				}
				else
				{
					dic.Add(strArray[i],pattern[i]);
				}
			}

			return true;
		}
	}
}
