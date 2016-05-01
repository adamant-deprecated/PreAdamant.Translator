using PreAdamant.Translator.Common;
using PreAdamant.Translator.Framework.Grammar;

namespace PreAdamant.Translator.Framework.Syntax
{
	public abstract class SyntaxNode
	{
		public string Type { get; }

		protected SyntaxNode(string type)
		{
			Requires.NotNullOrEmpty(type, nameof(type));

			Type = type;
		}

		public abstract bool Validate(Language language);
	}
}
