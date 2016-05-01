using System;
using PreAdamant.Translator.Framework.Grammar;
using PreAdamant.Translator.Framework.Syntax;

namespace PreAdamant.Translator.Framework.Compilation
{
	public static class CompilerPass
	{
		public static CompilerPass<T> Define<T>(string name, Language inputLanguage)
		{
			throw new NotImplementedException();
		}

		public static CompilerPass<SyntaxTree> Define(string name, Language inputLanguage, Language outputLanguage)
		{
			return new CompilerPass<SyntaxTree>(name, inputLanguage, outputLanguage);
		}
	}

	public class CompilerPass<TOutput>
	{
		public readonly string Name;
		public readonly Language InputLanguage;
		public readonly Language OutputLanguage;

		internal CompilerPass(string name, Language inputLanguage, Language outputLanguage)
		{
			Name = name;
			InputLanguage = inputLanguage;
			OutputLanguage = outputLanguage;
		}

		public SyntaxNode Transform(SyntaxNode syntaxNode)
		{
			throw new NotImplementedException();
		}
	}
}
