using System;
namespace TDDArg
{
	public class NthDigit
	{
		public int FindNthDigit(int n)
		{
			if (n <= 9)
			{
				return n;
			}

			return 0;
		}
	}
}
