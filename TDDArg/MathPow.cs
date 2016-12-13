using System;
namespace TDDArg
{
	public class MathPow
	{
		public static double MyPow(double x, int n)
		{
			if (n == 0) return 1;

			return x * MyPow(x, n - 1);
		}
	}
}
