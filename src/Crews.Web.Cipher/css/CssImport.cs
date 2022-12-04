namespace Crews.Web.Cipher.Css;

/// <summary>
/// Represents a CSS import rule.
/// </summary>
public class CssImport : CssAtRule
{
	/// <summary>
	/// The rule constructor.
	/// </summary>
	/// <param name="import">The import expression.</param>
	public CssImport(string import) : base($"import {import};") { }
}