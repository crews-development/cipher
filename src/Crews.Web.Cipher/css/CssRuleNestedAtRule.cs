namespace Crews.Web.Cipher.Css;

/// <summary>
/// Represents an at-rule nested within another CSS rule.
/// </summary>
public abstract class CssRuleNestedAtRule : CssNestedAtRule
{
	/// <summary>
	/// Rules contained in the rule.
	/// </summary>
	public IEnumerable<CssRule> Rules { get; set; } = new List<CssRule>();

	/// <summary>
	/// At-rules contained in the rule.
	/// </summary>
	public IEnumerable<CssAtRule> AtRules { get; set; }
		= new List<CssAtRule>();

	/// <summary>
	/// Rule constructor.
	/// </summary>
	/// <param name="name">The name of the rule.</param>
	public CssRuleNestedAtRule(string name) : base(name) { }

	/// <summary>
	/// Converts this rule to its CSS-compatible string representation.
	/// </summary>
	/// <returns>Returns the string representation of the rule.</returns>
	public override string ToString()
	{
		_content = string.Join("", Rules
			.Select(r => r.ToString()));
		_content += string.Join("", AtRules
			.Select(a => a.ToString()));

		return base.ToString();
	}
}