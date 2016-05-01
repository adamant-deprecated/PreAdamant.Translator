using PreAdamant.Translator.Framework;
using PreAdamant.Translator.Framework.Compilation;
using PreAdamant.Translator.Framework.Grammar;

namespace PreAdamant.Translator.Transforms
{
	public static class Languages
	{
		public static readonly Language UnparsedCompilationUnit = Language.Named("UnparsedCompilationUnit")
			.Extends(SourcePreparer.Instance.Language)
			.Where("compilationUnit", "SourceText")
			.Define();

		public static readonly Language PreprocessorDirectives = Language.Named("PreprocessorDirectives")
			.Extends(SourcePreparer.Instance.Language)
			.Define();

		public static readonly Language FullLexical = Language.Named("FullLexical")
			.Over("DocCommentLine, SingleLineComment, BlockComment, Whitespace, Using, Namespace")
			.Define();
	}
}
