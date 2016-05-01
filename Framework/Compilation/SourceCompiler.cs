using System;
using PreAdamant.Translator.Framework.Syntax;

namespace PreAdamant.Translator.Framework.Compilation
{
	/// <summary>
	/// Compiles a SourceText into a SyntaxForest
	/// </summary>
	public class SourceCompiler
	{
		public readonly ISourceTextPreparer SourceTextPreparer;

		public SourceCompiler(ISourceTextPreparer sourceTextPreparer)
		{
			SourceTextPreparer = sourceTextPreparer;
		}

		public SyntaxTree Compile(SourceText text, bool validate = false)
		{
			var initialTree = SourceTextPreparer.Prepare(text);
			throw new NotImplementedException();
		}
	}
}
