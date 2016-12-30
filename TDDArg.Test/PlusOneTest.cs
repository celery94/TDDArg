using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TDDArg.Test
{
    [TestFixture]
    public class PlusOneTest
    {
        [Test]
        public void Given_1_When_add_Then_return_2()
        {
            var digits = new int[] { 1 };

            var result = new int[] { 2 };

            Assert.AreEqual(result, PlusOne.GetPlusOne(digits));
        }

        [Test]
        public void Given_9_When_add_Then_return_10()
        {
            var digits = new int[] { 9 };

            var result = new int[] { 1, 0 };

            Assert.AreEqual(result, PlusOne.GetPlusOne(digits));
        }
    }
}
