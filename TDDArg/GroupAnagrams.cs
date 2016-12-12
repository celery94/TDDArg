using System;
using System.Collections.Generic;

namespace TDDArg
{
	public class GroupAnagrams
	{
		public static IList<IList<string>> FindGroupAnagrams(string[] strs)
		{
			var result = new List<IList<string>>();

			foreach (var str in strs)
			{
				bool isFind = false;
				foreach (var item in result)
				{
					if (IsSame(str, item[0]))
					{
						item.Add(str);
						isFind = true;
						break;
					}
				}

				if (!isFind)
					result.Add(new List<string> { str });
			}

			return result;
		}

		public static bool IsSame(string a, string b)
		{
			if (a.Length != b.Length) return false;

			var contain = new bool[a.Length];

			foreach (var aItem in a)
			{
				for (int i = 0; i < b.Length; i++)
				{
					if (contain[i]) continue;

					if (aItem == b[i])
					{
						contain[i] = true;
						break;
					}
				}
			}

			for (int i = 0; i < b.Length; i++)
			{
				if (contain[i] == false) return false;
			}

			return true;
		}
	}
}
