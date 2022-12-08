using Crews.Web.Cipher.Css.Selectors;

namespace Crews.Web.Cipher.Css;

/// <summary>
/// Represents a standard CSS rule.
/// </summary>
public class Rule
{
	/// <summary>
	/// The selectors of the rule.
	/// </summary>
	public IEnumerable<Selector> Selectors { get; set; }

	/// <summary>
	/// The rule's declarations.
	/// </summary>
	public IEnumerable<Declaration> Declarations { get; set; }

	/// <summary>
	/// Creates a new CssRule instance.
	/// </summary>
	/// <param name="selector">A CSS selector.</param>
	/// <param name="declarations">A set of CSS declarations.</param>
	public Rule(Selector selector, IEnumerable<Declaration> declarations)
		: this(new List<Selector> { selector }, declarations) { }

	/// <summary>
	/// Creates a new CssRule instance.
	/// </summary>
	/// <param name="selectors">A set of CSS selectors.</param>
	/// <param name="declarations">A set of CSS declarations.</param>
	public Rule(IEnumerable<Selector> selectors, IEnumerable<Declaration> declarations)
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