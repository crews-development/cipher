namespace Crews.Web.Cipher.Css;

/// <summary>
/// Represents a CSS combinator selector.
/// </summary>
public abstract class SelectorCombination : Selector
{
	/// <summary>
	/// Combinator constructor.
	/// </summary>
	/// <param name="combinator">The combinator separator.</param>
	/// <param name="baseSelectors">The selectors to combine.</param>
	public SelectorCombination(char combinator, params Selector[] baseSelectors)
		: base(GetBaseSelector(combinator, baseSelectors)) { }

	private static string GetBaseSelector(char combinator, Selector[] selectors) =>
		string.Join(combinator, selectors.Select(s => s.ToString()));
}
