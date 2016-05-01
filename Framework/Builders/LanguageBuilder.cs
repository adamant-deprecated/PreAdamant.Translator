using System;
using System.Collections.Generic;
using System.Linq;
using PreAdamant.Translator.Framework.Grammar;

namespace PreAdamant.Translator.Framework.Builders
{
	public class LanguageBuilder
	{
		private readonly string name;
		private bool extendingLanguage;
		private HashSet<string> terminals = new HashSet<string>();
		private Dictionary<string, HashSet<string>> productions = new Dictionary<string, HashSet<string>>();

		public LanguageBuilder(string name)
		{
			this.name = name;
		}

		public LanguageBuilder Extends(Language language)
		{
			extendingLanguage = true;
			terminals = new HashSet<string>(language.Terminals);
			// TODO set productions
			return this;
		}

		public LanguageBuilder Over(string terminalsSpec)
		{
			foreach(var terminal in terminalsSpec.Split(',').Select(terminal => terminal.Trim()))
			{
				if(terminal.StartsWith("+"))
				{
					if(!extendingLanguage) throw new NotSupportedException("Can't use + when defining terminals and not extending a language");
					// TODO validate terminal is an identifier
					terminals.Add(terminal.Substring(1));
				}
				else if(terminal.StartsWith("-"))
				{
					if(!extendingLanguage) throw new NotSupportedException("Can't use - when defining terminals and not extending a language");
					// TODO validate terminal is an identifier
					terminals.Remove(terminal.Substring(1));
				}
				else
				{
					if(extendingLanguage) throw new NotSupportedException("Must use + when defining terminals and extending a language");
					// TODO validate terminal is an identifier
					terminals.Add(terminal);
				}
			}
			return this;
		}

		public LanguageBuilder Where(string nonterminal, params string[] alternatives)
		{
			HashSet<string> existingAlternatives;
			if(!productions.TryGetValue(nonterminal, out existingAlternatives))
				productions[nonterminal] = existingAlternatives = new HashSet<string>();

			foreach(var alternative in alternatives)
				existingAlternatives.Add(alternative);

			return this;
		}

		public Language Define()
		{
			return new Language(name, terminals); // TODO pass rest of values;
		}
	}
}
