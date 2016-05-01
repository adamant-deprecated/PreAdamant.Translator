using PreAdamant.Translator.Framework;
using PreAdamant.Translator.Framework.Compilation;
using PreAdamant.Translator.Framework.Syntax;

namespace PreAdamant.Translator.Transforms
{
	public static class PreAdamantTranslator
	{
		public static readonly CompilerPass<SyntaxTree> PrepareCompilationUnit; 
		public static readonly CompilerPass<SyntaxTree> Preprocessor;
		public static readonly CompilerPass<SyntaxTree> Lexer;
		// TODO SourceCompiler
		// TODO PackageCompiler
		// TODO Emitter
		static PreAdamantTranslator()
		{
			PrepareCompilationUnit = CompilerPass.Define("PrepareCompilationUnit", SourcePreparer.Instance.Language,
				Languages.UnparsedCompilationUnit);
			Preprocessor = CompilerPass.Define("Preprocessor", SourcePreparer.Instance.Language, SourcePreparer.Instance.Language);
			Lexer = null;
		}
	}
}
