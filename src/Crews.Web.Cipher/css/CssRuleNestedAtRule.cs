namespace Crews.Web.Cipher.Css;

public abstract class CssRuleNestedAtRule : CssNestedAtRule
{
	public IEnumerable<CssRule> Rules { get; set; } = new List<CssRule>();

	public IEnumerable<CssAtRule> AtRules { get; set; }
		= new List<CssAtRule>();

	public CssRuleNestedAtRule(string name) : base(name) { }

	public override string ToString()
	{
		_content = string.Join("", Rules
			.Select(r => r.ToString()));
		_content += string.Join("", AtRules
			.Select(a => a.ToString()));

		return base.ToString();
	}
}