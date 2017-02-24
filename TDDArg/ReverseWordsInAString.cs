using NUnit.Framework;

namespace TDDArg
{
    [TestFixture]
    public class ReverseWordsInAString
    {
        public string ReverseWords(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return string.Empty;

            var array = s.ToCharArray();

            int start = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (array[i] == ' ')
                {
                    Reserse(array, start, i - 1);
                    start = i + 1;
                }
                else if (i == s.Length - 1)
                {
                    Reserse(array, start, i);
                }
            }

            Reserse(array, 0, s.Length - 1);

            return string.Join("", array);
        }

        private void Reserse(char[] array, int start, int end)
        {
            while (start < end)
            {
                var tmp = array[start];
                array[start] = array[end];
                array[end] = tmp;
                start++;
                end--;
            }
        }

        [Test]
        public void Given_string_When_reverse_Then_return()
        {
            var result = ReverseWords("the sky is blue");

            Assert.AreEqual("blue is sky the", result);
        }

        [Test]
        public void Given_empty_string_When_reverse_Then_return()
        {
            var result = ReverseWords("");

            Assert.AreEqual("", result);
        }
    }
}