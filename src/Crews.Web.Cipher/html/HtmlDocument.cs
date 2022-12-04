namespace Crews.Web.Cipher.Html;

/// <summary>
/// Represents a complete HTML document.
/// </summary>
public class HtmlDocument : HtmlElement
{
	/// <summary>
	/// Document constructor.
	/// </summary>
	public HtmlDocument() : base("html") { }

	/// <summary>
	/// Serializes all child elements, automatically wrapping them in an html tag and prepending the DOCTYPE.
	/// </summary>
	/// <returns>Returns a string containing the serialized HTML document.</returns>
	public override string ToString()
	{
		string html = base.ToString();
		return $"<!DOCTYPE html>{html}";
	}
}
