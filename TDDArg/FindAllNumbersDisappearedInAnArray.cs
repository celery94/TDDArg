using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace TDDArg
{
    [TestFixture]
    public class FindAllNumbersDisappearedInAnArray
    {
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            int index = 0;

            while (index < nums.Length)
            {
                if (nums[index] != index + 1 && nums[nums[index] - 1] != nums[index])
                {
                    var tmp = nums[nums[index] - 1];
                    nums[nums[index] - 1] = nums[index];
                    nums[index] = tmp;
                }
                else
                {
                    index++;
                }
            }

            List<int> result = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != i + 1) result.Add(i + 1);
            }

            return result;
        }

        public IList<int> FindDisappearedNumbersII(int[] nums)
        {
            foreach (var num in nums)
            {
                var index = Math.Abs(num) - 1;

                if (nums[index] > 0)
                {
                    nums[index] = 0 - nums[index];
                }
            }

            List<int> result = new List<int>();
            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0) result.Add(i + 1);
            }

            return result;
        }

        [Test]
        public void Test()
        {
            var result = FindDisappearedNumbers(new int[] { 4, 3, 2, 7, 8, 2, 3, 1 });

            Assert.AreEqual(2, result.Count);
        }
    }
}