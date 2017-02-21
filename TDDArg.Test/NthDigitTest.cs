using System;
using NUnit.Framework;

namespace TDDArg.Test
{
	[TestFixture]
	public class NthDigitTest
	{
		[Test]
		public void When_find_5_Then_return_5()
		{
			Assert.AreEqual(5, new NthDigit().FindNthDigit(5));
		}

		[Test]
		public void When_find_11_Then_return_0()
		{
			Assert.AreEqual(0, new NthDigit().FindNthDigit(11));
		}
	}
}
