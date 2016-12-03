using NUnit.Framework;

namespace TDDArg.Test
{
    [TestFixture]
    public class ImplementStrStrTest
    {
        [Test]
        public void Given_two_string_When_search_Then_return_index()
        {
            Assert.AreEqual(0, ImplementStrStr.StrStr("abcde", "abc"));
        }
    }
}