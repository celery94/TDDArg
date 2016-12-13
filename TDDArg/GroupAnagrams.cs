using System;
using System.Collections.Generic;
using System.Linq;

namespace TDDArg
{
	public class GroupAnagrams
	{
		public static IList<IList<string>> FindGroupAnagrams(string[] strs)
		{
			Dictionary<string, IList<string>> list = new Dictionary<string, IList<string>>();

			foreach (var str in strs)
			{
				var key = string.Join("", str.OrderBy(q => q));

				if (list.ContainsKey(key))
				{
					list[key].Add(str);
					continue;
				}
				else
				{
					list.Add(key, new List<string> { str });
				}
			}

			return list.Values.ToList();
		}
	}
}
