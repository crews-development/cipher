namespace Crews.Web.Cipher.Css.Selectors;

/// <summary>
/// A CSS selector combination that uses the descendant combinator (space).
/// </summary>
public class DescendantSelector : SelectorCombination
{
	/// <inheritdoc cref="SelectorCombination(char, Selector[])" />
	public DescendantSelector(params Selector[] baseSelectors)
		: base(' ', baseSelectors) { }
}
