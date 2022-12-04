namespace Crews.Web.Cipher.Css;

public abstract class CssAtRule
{
	protected string _name;

	public CssAtRule(string name) => _name = name;

	public override string ToString() => $"@{_name}";
}