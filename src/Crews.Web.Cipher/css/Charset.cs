namespace Crews.Web.Cipher.Css;

/// <summary>
/// Represents a CSS character set selection.
/// </summary>
public class Charset : AtRule
{
	/// <summary>
	/// The rule constructor.
	/// </summary>
	/// <param name="charset">The selected character set.</param>
	public Charset(string charset) : base($"charset \"{charset}\";") { }
}