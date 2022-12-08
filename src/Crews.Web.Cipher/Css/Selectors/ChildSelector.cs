namespace Crews.Web.Cipher.Css.Selectors;

/// <summary>
/// A CSS selector combination that uses the child combinator (>).
/// </summary>
public class ChildSelector : SelectorCombination
{
	/// <inheritdoc cref="SelectorCombination(char, Selector[])" />
	public ChildSelector(params Selector[] baseSelectors)
		: base('>', baseSelectors) { }
}
