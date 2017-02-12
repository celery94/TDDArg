using System;
namespace TDDArg
{
	public class ReverseString
	{
		public string ReverseStringHelper(string s)
		{
			var array = s.ToCharArray();

			int start = 0;
			int end = array.Length - 1;

			while (start < end)
			{
				var tmp = array[start];
				array[start] = array[end];
				array[end] = tmp;

				start++;
				end--;
			}

			return string.Join("", array);
		}
	}
}
