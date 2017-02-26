using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace TDDArg
{
	[TestFixture]
	public class WordBreakClass
	{
		public bool WordBreak(string s, IList<string> wordDict)
		{
			int start = 0;
			int length = 1;

			while (start + length <= s.Length)
			{
				if (wordDict.Contains(s.Substring(start, length)))
				{
					if (start + length == s.Length) return true;

					start = start + length;
					length = 1;
				}
				else
				{
					length++;
				}
			}

			return false;
		}

		[Test]
		public void Given_string_dic_When_find_Then_return()
		{
			var wordDic = new List<string> { "dog", "s","gs" };
			Assert.IsTrue(WordBreak("dogs", wordDic));
		}
	}
}
