namespace Crews.Web.Cipher.Css;

/// <summary>
/// Represents a single selector for a CSS rule.
/// </summary>
public class CssSelector
{
	/// <summary>
	/// The tag, element, or class of the selector.
	/// </summary>
	public string BaseSelector { get; set; }

	/// <summary>
	/// The pseudo class of the selector.
	/// </summary>
	public string? PseudoClass { get; set; }

	/// <summary>
	/// The pseudo element of the selector.
	/// </summary>
	public string? PseudoElement { get; set; }

	/// <summary>
	/// Creates a new CssSelector instance.
	/// </summary>
	/// <param name="baseSelector">The tag, element, or class of the selector.</param>
	/// <param name="pseudoClass">The pseudo class of the selector.</param>
	/// <param name="pseudoElement">The pseudo element of the selector.</param>
	public CssSelector(string baseSelector, string? pseudoClass = null, string? pseudoElement = null)
	{
		BaseSelector = baseSelector;
		PseudoClass = pseudoClass;
		PseudoElement = pseudoElement;
	}

	/// <summary>
	/// Gets a string representation of the selector and, optionally, its pseudo class and/or pseudo element.
	/// </summary>
	/// <returns>Returns a string representing the selector.</returns>
	public override string ToString()
	{
		string output = BaseSelector.Replace(' ', '-');

		if (PseudoClass != null) output += $":{PseudoClass}";
		if (PseudoElement != null) output += $"::{PseudoElement}";

		return output;
	}
}