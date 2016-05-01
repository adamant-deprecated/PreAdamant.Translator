using PreAdamant.Translator.Framework.Grammar;
using PreAdamant.Translator.Framework.Syntax;

namespace PreAdamant.Translator.Framework.Compilation
{
	/// <summary>
	/// Prepares a source text as a SyntaxTree of SyntaxText nodes containing
	/// a single Unicode codepoint each.
	/// </summary>
	public class SourcePreparer : ISourceTextPreparer
	{
		#region Singleton
		public static readonly SourcePreparer Instance = new SourcePreparer();

		private SourcePreparer()
		{
		}
		#endregion

		public SyntaxNode Prepare(SourceText text)
		{
			return new SyntaxText("SourceText", text, new TextSpan(0, text.Content.Length));
		}

		//private static IEnumerable<SyntaxNode> PrepareNodes(SourceText text)
		//{
		//	// This tight loop might actually benifit from saving these out into variables.
		//	var content = text.Content;
		//	var length = content.Length;
		//	for(var i = 0; i < length; i++)
		//	{
		//		if(char.IsHighSurrogate(content, i))
		//		{
		//			var nextChar = i + 1;
		//			if(nextChar == length)
		//				throw new Exception($"High surrogate occurs as last character of text {text.Package}: {text.Name}");
		//			if(!char.IsLowSurrogate(content, nextChar))
		//				throw new Exception($"High surrogate at {i} does not have matching surrogate in {text.Package}: {text.Name}");
		//			yield return new SyntaxText(text, new TextSpan(i, 2));
		//			i++; // skip the low surrogate
		//		}
		//		else if(char.IsLowSurrogate(content, i))
		//			throw new Exception($"Low surrogate at {i} does not have matching surrogate in {text.Package}: {text.Name}");

		//		yield return new SyntaxText(text, new TextSpan(i, 1));
		//	}
		//}

		public readonly Language Language = Language.Named("SourceText").Over("SourceText").Define();
	}
}
