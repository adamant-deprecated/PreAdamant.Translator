using System.Collections.Generic;
using System.Linq;
using PreAdamant.Translator.Common;
using PreAdamant.Translator.Framework.Grammar;

namespace PreAdamant.Translator.Framework.Syntax
{
	public class SyntaxTree : SyntaxNode
	{
		public readonly IReadOnlyList<SyntaxNode> Children;

		public SyntaxTree(string type, IEnumerable<SyntaxNode> children)
			: base(type)
		{
			Requires.That(char.IsLower(type[0]), nameof(type), "Must start with lowercase letter");
			Children = children.ToList();
		}

		public override bool Validate(Language language)
		{
			throw new System.NotImplementedException();
		}
	}
}
