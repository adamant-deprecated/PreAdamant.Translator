namespace PreAdamant.Translator.Framework.Syntax
{
	public class SourceText
	{
		public readonly string Package;
		public readonly string Name;
		public readonly string Content;

		public SourceText(string package, string name, string content)
		{
			Package = package;
			Name = name;
			Content = content;
		}
	}
}
