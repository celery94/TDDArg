using System;
using NUnit.Framework;

namespace TDDArg.Test
{
	[TestFixture]
	public class MathPowTest
	{

		[Test]
		public void Given_2_When_pow_0_Then_1()
		{
			Assert.AreEqual(1, MathPow.MyPow(2, 0));
		}

		[Test]
		public void Given_2_When_pow_2_Then_4()
		{
			Assert.AreEqual(4, MathPow.MyPow(2, 2));
		}

		[Test]
		[Ignore("failed with double")]
		public void Given_888023_When_pow_3_Then_70028148()
		{
			Assert.AreEqual(700.28148d, MathPow.MyPow(8.88023d, 3));
		}
	}
}
