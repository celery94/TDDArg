using System;
using System.Collections.Generic;
using System.Linq;

namespace TDDArg
{
	public class MergeIntervals
	{
		public static IList<Interval> Merge(IList<Interval> intervals)
		{
			var result = new List<Interval>();
			if (intervals.Count == 0) return result;

			intervals = intervals.OrderBy(q => q.start).ToList();

			int start = intervals[0].start;
			int end = intervals[0].end;

			foreach (var interval in intervals) {
				if (interval.start <= end)
				{
					end = Math.Max(interval.end, end);
				}
				else {
					result.Add(new Interval(start, end));
					start = interval.start;
					end = interval.end;
				}
			}

			result.Add(new Interval(start, end));

			return result;
		}
	}
}
