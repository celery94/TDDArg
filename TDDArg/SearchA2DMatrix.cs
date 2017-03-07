using System;
using NUnit.Framework;

namespace TDDArg
{
	[TestFixture]
	public class SearchA2DMatrix
	{
		public bool SearchMatrix(int[,] matrix, int target)
		{
			var row = matrix.GetLength(0);
			var column = matrix.GetLength(1);

			if (column == 0) return false;

			for (int i = row - 1; i >= 0; i--)
			{
				if (target >= matrix[i, 0])
				{
					for (int j = 0; j < column; j++)
					{
						if (matrix[i, j] == target)
						{
							return true;
						}
					}

					return false;
				}
			}

			return false;
		}

		[Test]
		public void Given_empty_When_search_0_Then_false()
		{
			Assert.IsFalse(SearchMatrix(new int[0, 0], 0));
		}


		[Test]
		public void Given_matrix_When_search_0_Then_false()
		{
			var matrix = new int[,] {
				{1,3,5,7},
				{9,11,12,23}
			};

			Assert.IsTrue(SearchMatrix(matrix, 3));
		}
	}
}
