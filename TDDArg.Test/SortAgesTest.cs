using System;
using NUnit.Framework;

namespace TDDArg.Test
{
	[TestFixture]
	public class SortAgesTest
	{
		[Test]
		public void Given_ages_When_sort_Then_return()
		{
			var ages = new int[] { 4, 1, 2, 3, 4, 5, 3, 6, 7, 5, 4 };

			SortAges.Sort(ages);

			Assert.AreEqual(1, ages[0]);
		}
	}
}
