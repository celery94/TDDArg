using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace TDDArg.Test
{
	[TestFixture]
	public class MergeIntervalsTest
	{
		[Test]
		public void Given_intervals_When_merge_Then_return()
		{
			List<Interval> intervals = new List<Interval>
			{
				new Interval(1,3),
				new Interval(2,6),
				new Interval(8,10),
				new Interval(15,18),
			};

			var result = MergeIntervals.Merge(intervals);

			Assert.AreEqual(3, result.Count);

			Assert.AreEqual(1, result[0].start);
			Assert.AreEqual(6, result[0].end);

			Assert.AreEqual(8, result[1].start);
			Assert.AreEqual(10, result[1].end);

			Assert.AreEqual(15, result[2].start);
			Assert.AreEqual(18, result[2].end);
		}
	}
}
