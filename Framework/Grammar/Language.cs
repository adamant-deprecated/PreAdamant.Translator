using System.Collections.Generic;
using System.Linq;
using PreAdamant.Translator.Framework.Builders;

namespace PreAdamant.Translator.Framework.Grammar
{
	public class Language
	{
		public string Name { get; }
		public IReadOnlyList<string> Terminals { get; }

		public Language(string name, IEnumerable<string> terminals)
		{
			Name = name;
			Terminals = terminals.OrderBy(t => t).ToList();
		}

		public static LanguageBuilder Named(string name)
		{
			return new LanguageBuilder(name);
		}
	}
}
