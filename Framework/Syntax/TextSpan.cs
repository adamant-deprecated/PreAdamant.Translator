using System.Diagnostics.Contracts;

namespace PreAdamant.Translator.Framework.Syntax
{
	public struct TextSpan
	{
		public readonly int Start;
		public readonly int Length;

		public TextSpan(int start, int length)
		{
			Start = start;
			Length = length;
		}

		[Pure]
		public string Of(string text)
		{
			return text.Substring(Start, Length);
		}
	}
}
