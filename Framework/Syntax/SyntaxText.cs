using System.Linq;
using PreAdamant.Translator.Common;
using PreAdamant.Translator.Framework.Grammar;

namespace PreAdamant.Translator.Framework.Syntax
{
	public class SyntaxText : SyntaxNode
	{
		public readonly SourceText SourceText;
		public readonly TextSpan Span;
		private string text;

		public SyntaxText(string type, SourceText sourceText, TextSpan span)
			: base(type)
		{
			Requires.That(char.IsUpper(type[0]), nameof(type), "Must start with uppercase letter");

			SourceText = sourceText;
			Span = span;
		}

		public string Text => text ?? (text = Span.Of(SourceText.Content));
		public override bool Validate(Language language)
		{
			return language.Terminals.Contains(Type);
		}
	}
}
