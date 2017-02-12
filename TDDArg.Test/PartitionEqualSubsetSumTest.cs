using System;
using NUnit.Framework;

namespace TDDArg.Test
{
	[TestFixture]
	public class PartitionEqualSubsetSumTest
	{
		[Test]
		public void Given_array_When_find_Then_return()
		{
			Assert.AreEqual(true, PartitionEqualSubsetSum.CanPartition(new int[] { 1, 11, 5, 5 }));
		}
	}
}
