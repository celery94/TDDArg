using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace TDDArg.Test
{
	[TestFixture]
	public class InsertIntervalTest
	{
		[Test]
		public void Given_intervals_When_insert_Then_return()
		{
			var intervals = new List<Interval>
			{
				new Interval(1,2),
				new Interval(3,5),
				new Interval(6,7),
				new Interval(8,10),
				new Interval(12,16),
			};

			var result = InsertInterval.Insert(intervals, new Interval(4, 9));

			Assert.AreEqual(3, result.Count);
		}
	}
}
