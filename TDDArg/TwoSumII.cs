using System;
namespace TDDArg
{
	public class TwoSumII
	{
		public static int[] TwoSum(int[] numbers, int target)
		{
			int s = 0;
			int e = numbers.Length - 1;

			while (s < e)
			{
				if ((numbers[s] + numbers[e]) == target)
					return new int[] { numbers[s], numbers[e] };
				else if ((numbers[s] + numbers[e]) < target)
					s++;
				else
					e--;
			}

			return new int[] { };
		}
	}
}
