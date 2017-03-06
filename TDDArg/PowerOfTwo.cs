﻿using System;
namespace TDDArg
{
	public class PowerOfTwo
	{
		public bool IsPowerOfTwo(int n)
		{
			return n > 0 && (n & (n - 1)) == 0;
		}
	}
}
