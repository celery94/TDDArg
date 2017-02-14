using System;
using NUnit.Framework;

namespace TDDArg.Test
{
	[TestFixture]
	public class FibonacciTest
	{

		[Test]
		public void Given_0_When_Sum_Then_return_0()
		{
			Assert.AreEqual(0, Fibonacci.FindSum(0));
		}

		[Test]
		public void Given_1_When_Sum_Then_return_1()
		{
			Assert.AreEqual(1, Fibonacci.FindSum(1));
		}

		[Test]
		public void Given_2_When_Sum_Then_return_2()
		{
			Assert.AreEqual(1, Fibonacci.FindSum(2));
		}

		[Test]
		public void Given_3_When_Sum_Then_return_2()
		{
			Assert.AreEqual(2, Fibonacci.FindSum(3));
		}

		[Test]
		public void Given_4_When_Sum_Then_return_3()
		{
			Assert.AreEqual(3, Fibonacci.FindSum(4));
		}

		[Test]
		public void Given_5_When_Sum_Then_return_5()
		{
			Assert.AreEqual(5, Fibonacci.FindSum(5));
		}
	}
}
