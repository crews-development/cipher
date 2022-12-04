namespace Crews.Web.Cipher.Css;

/// <summary>
/// Represents a CSS character set selection.
/// </summary>
public class CssCharset : CssAtRule
{
	/// <summary>
	/// The rule constructor.
	/// </summary>
	/// <param name="charset">The selected character set.</param>
	public CssCharset(string charset) : base($"charset \"{charset}\";") { }
}