using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace TDDArg.Test
{
	[TestFixture]
	public class PermutationsTest
	{
		[Test]
		public void Given_2_items_array_When_permute_Then_return()
		{
			var nums = new int[] { 2, 3 };

			var expectResult = new List<IList<int>>
			{
				new List<int>{2,3},
				new List<int>{3,2},
			};

			Assert.AreEqual(2, Permutations.Permute(nums).Count);
		}

		[Test]
		public void Given_3_items_array_When_permute_Then_return()
		{
			var nums = new int[] {1, 2, 3 };

			var expectResult = new List<IList<int>>
			{
				new List<int>{2,3},
				new List<int>{3,2},
			};

			Assert.AreEqual(6, Permutations.Permute(nums).Count);
		}
	}
}
