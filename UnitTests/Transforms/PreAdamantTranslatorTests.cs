using NUnit.Framework;
using PreAdamant.Translator.Framework;
using PreAdamant.Translator.Framework.Compilation;
using PreAdamant.Translator.Framework.Syntax;
using PreAdamant.Translator.Transforms;

namespace PreAdamant.Translator.UnitTests.Transforms
{
	[TestFixture]
	public class PreAdamantTranslatorTests
	{
		[Test]
		public void PrepareCompilationUnit()
		{
			var syntaxNode = PrepareSource("/* some source */");
			var pass = PreAdamantTranslator.PrepareCompilationUnit;
			Assert.IsTrue(syntaxNode.Validate(pass.InputLanguage), "Input Valid");
			syntaxNode = pass.Transform(syntaxNode);
			Assert.IsTrue(syntaxNode.Validate(pass.OutputLanguage), "Output Valid");
			const string expected = @"(compilationUnit (SourceText '/* some source */'))";
			Assert.AreEqual(expected, syntaxNode.ToString());
		}

		private static SyntaxNode PrepareSource(string source)
		{
			var sourceText = new SourceText("UnitTest", "UnitTest.adam", source);
			var syntaxNode = SourcePreparer.Instance.Prepare(sourceText);
			return syntaxNode;
		}
	}
}
