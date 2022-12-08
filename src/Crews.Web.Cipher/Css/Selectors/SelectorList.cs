namespace Crews.Web.Cipher.Css.Selectors;

/// <summary>
/// A CSS selector combination that uses the list combinator (,).
/// </summary>
public class SelectorList : SelectorCombination
{
	/// <inheritdoc cref="SelectorCombination(char, Selector[])" />
	public SelectorList(params Selector[] baseSelectors)
		: base(',', baseSelectors) { }
}
