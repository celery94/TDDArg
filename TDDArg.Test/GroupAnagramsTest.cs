using System;
using NUnit.Framework;

namespace TDDArg.Test
{
	[TestFixture]
	public class GroupAnagramsTest
	{
		[Test]
		public void Given_array_When_group_Then_return_one()
		{
			var strs = new string[] { "eat", "ate", "tea" };

			var result = GroupAnagrams.FindGroupAnagrams(strs);

			Assert.AreEqual(1, result.Count);
		}

		[Test]
		public void Given_array_When_group_Then_return_two()
		{
			var strs = new string[] { "eat", "ate", "tea", "aaa" };

			var result = GroupAnagrams.FindGroupAnagrams(strs);

			Assert.AreEqual(2, result.Count);
		}


		[Test]
		public void Given_array_When_group_Then_return_only_one()
		{
			var strs = new string[] { "dad", "day" };

			var result = GroupAnagrams.FindGroupAnagrams(strs);

			Assert.AreEqual(2, result.Count);
		}
	}
}
