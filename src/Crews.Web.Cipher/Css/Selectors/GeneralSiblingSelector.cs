namespace Crews.Web.Cipher.Css.Selectors;

/// <summary>
/// A CSS selector combination that uses the general sibling combinator (~).
/// </summary>
public class GeneralSiblingSelector : SelectorCombination
{
	/// <inheritdoc cref="SelectorCombination(char, Selector[])" />
	public GeneralSiblingSelector(params Selector[] baseSelectors)
		: base('~', baseSelectors) { }
}
