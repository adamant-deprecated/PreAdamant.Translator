using System.Collections.Generic;
using System.Linq;

namespace PreAdamant.Translator.Framework.Grammar
{
	public class Production
	{
		public readonly string Symbol;
		public readonly IReadOnlyList<Alternative> Alternatives;

		public Production(string symbol, IEnumerable<Alternative> alternatives)
		{
			Symbol = symbol;
			Alternatives = alternatives.ToList();
		}
	}
}
