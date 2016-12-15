using System;
using NUnit.Framework;

namespace TDDArg.Test
{
	[TestFixture]
	public class LengthOfLastWordTest
	{
		[Test]
		public void Given_str_When_find_Then_return()
		{
			Assert.AreEqual(5, LengthOfLastWord.FindLengthOfLastWord("Hello World"));
		}

		[Test]
		public void Given_str_end_with_space_When_find_Then_return_0()
		{
			Assert.AreEqual(5, LengthOfLastWord.FindLengthOfLastWord("Hello World "));
		}

		[Test]
		public void Given_str_end_without_space_When_find_Then_return_str_length()
		{
			Assert.AreEqual(1, LengthOfLastWord.FindLengthOfLastWord("a"));
		}
	}
}
