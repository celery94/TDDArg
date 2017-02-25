using System;
using NUnit.Framework;

namespace TDDArg
{
	[TestFixture]
	public class UrlReplace
	{
		string Replace(string url)
		{
			int spaceCount = 0;
			for (int i = 0; i < url.Length; i++)
			{
				if (url[i] == ' ') spaceCount++;
			}

			if (spaceCount == 0) return url;

			var array = new char[url.Length + spaceCount * 2];

			int arrayIndex = array.Length - 1;
			for (int index = url.Length - 1; index >= 0; index--)
			{
				if (url[index] == ' ')
				{
					array[arrayIndex] = '0';
					array[arrayIndex - 1] = '2';
					array[arrayIndex - 2] = '%';
					arrayIndex -= 3;
				}
				else
				{
					array[arrayIndex] = url[index];
					arrayIndex--;
				}
			}

			return string.Join("", array);
		}

		[Test]
		public void Given_url_When_replace_space_Then_return()
		{
			string url = "abc d ef";

			Assert.AreEqual("abc%20d%20ef", Replace(url));
		}

}
}
