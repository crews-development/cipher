namespace Crews.Web.Cipher.Css.Selectors;

/// <summary>
/// A CSS selector combination that uses the column combinator (||).
/// </summary>
public class ColumnSelector : SelectorCombination
{
	/// <inheritdoc cref="SelectorCombination(string, Selector[])" />
	public ColumnSelector(params Selector[] baseSelectors)
		: base("||", baseSelectors) { }
}
