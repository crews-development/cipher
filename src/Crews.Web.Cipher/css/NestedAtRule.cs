namespace Crews.Web.Cipher.Css;

/// <summary>
/// Represents a CSS at-rule nested within another at-rule.
/// </summary>
public class NestedAtRule : AtRule
{
	/// <summary>
	/// The content of the rule.
	/// </summary>
	protected string _content = String.Empty;

	/// <summary>
	/// Rule constructor.
	/// </summary>
	/// <param name="name">The name of the rule.</param>
	public NestedAtRule(string name) : base(name) { }

	/// <summary>
	/// Converts this nested rule to its CSS-compatible string representation.
	/// </summary>
	/// <returns>Returns a string representing the rule.</returns>
	public override string ToString() => base.ToString() + $" {{{_content}}}";
}