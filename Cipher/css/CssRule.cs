namespace Crews.Web.Cipher.Css;

/// <summary>
/// Represents a standard CSS rule.
/// </summary>
public class CssRule
{
	/// <summary>
	/// The selectors of the rule.
	/// </summary>
	public IEnumerable<CssSelector> Selectors { get; set; }

	/// <summary>
	/// The rule's declarations.
	/// </summary>
	public IEnumerable<CssDeclaration> Declarations { get; set; }

	/// <summary>
	/// Creates a new CssRule instance.
	/// </summary>
	/// <param name="selector">A CSS selector.</param>
	/// <param name="declarations">A set of CSS declarations.</param>
	public CssRule(CssSelector selector, IEnumerable<CssDeclaration> declarations)
		: this(new List<CssSelector> { selector }, declarations) { }

	/// <summary>
	/// Creates a new CssRule instance.
	/// </summary>
	/// <param name="selectors">A set of CSS selectors.</param>
	/// <param name="declarations">A set of CSS declarations.</param>
	public CssRule(IEnumerable<CssSelector> selectors, IEnumerable<CssDeclaration> declarations)
	{
		Selectors = selectors;
		Declarations = declarations;
	}

	/// <summary>
	/// Gets the string representation of the CSS rule.
	/// </summary>
	/// <returns>Returns a string representing the rule.</returns>
	public override string ToString()
	{
		string selectors = string.Join(',', Selectors.Select(s => s.ToString()));
		string declarations = string.Join("", Declarations.Select(d => d.ToString())).TrimEnd(';');

		return $"{selectors}{{{declarations}}}";
	}
}