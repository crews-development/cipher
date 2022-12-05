namespace Crews.Web.Cipher.Css;

/// <summary>
/// Represents a CSS import rule.
/// </summary>
public class Import : AtRule
{
	/// <summary>
	/// The rule constructor.
	/// </summary>
	/// <param name="import">The import expression.</param>
	public Import(string import) : base($"import {import};") { }
}