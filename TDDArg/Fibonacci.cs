using System;
namespace TDDArg
{
	public class Fibonacci
	{
		public static int FindSum(int n)
		{
			if (n == 0 || n == 1) return n;

			var result = new int[] { 0, 1 };
			for (int i = 2; i <= n; i++)
			{
				var sum = result[0] + result[1];
				result[0] = result[1];
				result[1] = sum;
			}

			return result[1];
		}
	}
}
