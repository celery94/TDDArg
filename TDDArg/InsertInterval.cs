using System;
using System.Collections.Generic;
using System.Linq;

namespace TDDArg
{
	public class InsertInterval
	{
		public static IList<Interval> Insert(IList<Interval> intervals, Interval newInterval)
		{
			var result = new List<Interval>();
			var list = intervals.ToList();
			list.Add(newInterval);
			list = list.OrderBy(q => q.start).ToList();

			int start = list[0].start;
			int end = list[0].end;

			foreach (var interval in list)
			{
				if (interval.start <= end)
				{
					end = Math.Max(interval.end, end);
				}
				else
				{
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
