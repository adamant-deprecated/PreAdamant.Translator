using PreAdamant.Translator.Framework.Syntax;

namespace PreAdamant.Translator.Framework.Compilation
{
	public interface ISourceTextPreparer
	{
		SyntaxNode Prepare(SourceText text);
	}
}