using NUnit.Framework;

namespace TDDArg.Test
{
    [TestFixture]
    public class FindMedianSortedArraysTest
    {
        [Test]
        public void FindMedianSortedArrays_Even_Test()
        {
            var nums1 = new[] {1, 3};
            var nums2 = new[] {2};

            double ret = FindMedianSortedArrays.FindMedianSortedArraysFunc(nums1, nums2);

            Assert.AreEqual((double) 2, ret);
        }

        [Test]
        public void FindMedianSortedArrays_Odd_Test()
        {
            var nums1 = new[] {1, 3};
            var nums2 = new[] {2, 4};

            double ret = FindMedianSortedArrays.FindMedianSortedArraysFunc(nums1, nums2);

            Assert.AreEqual((double) 2.5, ret);
        }

        [Test]
        public void FindMedianSortedArrays_Odd_Sort_Test()
        {
            var nums1 = new[] {1, 2};
            var nums2 = new[] {3, 4};

            double ret = FindMedianSortedArrays.FindMedianSortedArraysFunc(nums1, nums2);

            Assert.AreEqual((double) 2.5, ret);
        }
    }
}