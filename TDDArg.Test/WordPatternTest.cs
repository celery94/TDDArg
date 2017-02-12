using System;
using NUnit.Framework;

namespace TDDArg.Test
{
	[TestFixture]
	public class WordPatternTest
	{
		[Test]
		public void Given_pattern_str_When_match_Then_return()
		{
			var pattern = "abba";
			var str = "dog cat cat dog";
			Assert.AreEqual(true, WordPattern.FindWordPattern(pattern, str));
		}

		[Test]
		public void Given_pattern_str_When_match_Then_return_false()
		{
			var pattern = "abbb";
			var str = "dog cat cat dog";
			Assert.AreEqual(false, WordPattern.FindWordPattern(pattern, str));
		}


		[Test]
		public void Given_string_same_When_match_Then_return_false()
		{
			var pattern = "abba";
			var str = "dog dog dog dog";
			Assert.AreEqual(false, WordPattern.FindWordPattern(pattern, str));
		}
	}
}
