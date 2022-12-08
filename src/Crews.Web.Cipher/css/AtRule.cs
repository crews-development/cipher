namespace Crews.Web.Cipher.Css;

/// <summary>
/// Base class for a CSS 'at-rule'.
/// </summary>
public abstract class AtRule
{
	/// <summary>
	/// The name of the rule.
	/// </summary>
	protected string _name;

	/// <summary>
	/// Rule constructor.
	/// </summary>
	/// <param name="name">The name of the rule.</param>
	public AtRule(string name) => _name = name;

	/// <summary>
	/// Converts this rule to its CSS-compatible string representation.
	/// </summary>
	/// <returns>Returns a string representing the rule.</returns>
	public override string ToString() => $"@{_name}";
}