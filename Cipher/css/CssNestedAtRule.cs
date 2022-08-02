namespace Crews.Web.Cipher.Css;

public class CssNestedAtRule : CssAtRule
{
	protected string _content = "";

	public CssNestedAtRule(string name) : base(name) { }

	public override string ToString()
	{
		return base.ToString() + $" {{{_content}}}";
	}
}