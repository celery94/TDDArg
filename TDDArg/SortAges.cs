using System;
namespace TDDArg
{
	public class SortAges
	{
		public static void Sort(int[] ages)
		{
			var range = new int[200];

			foreach (var age in ages)
			{
				range[age]++;
			}

			int index = 0;
			for (int i = 0; i < 200; i++)
			{
				for (int j = 0; j < range[i]; j++)
				{
					ages[index] = i;
					index++;
				}
			}
		}
	}
}
