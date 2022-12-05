namespace Crews.Web.Cipher.Css;

/// <summary>
/// A CSS selector combination that uses the adjacent sibling combinator (+).
/// </summary>
public class AdjacentSiblingSelector : SelectorCombination
{
	/// <inheritdoc cref="SelectorCombination(char, Selector[])" />
	public AdjacentSiblingSelector(params Selector[] baseSelectors)
		: base('+', baseSelectors) { }
}
