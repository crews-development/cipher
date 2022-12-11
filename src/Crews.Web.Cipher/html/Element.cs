using System;

namespace Crews.Web.Cipher.Html;

/// <summary>
/// Represents an HTML element, its attributes, and its child elements.
/// </summary>
public abstract class Element
{
	private readonly string _tag;

	/// <summary>
	/// The child elements contained in this element.
	/// </summary>
	public List<Element> Children { get; set; } = new();

	/// <summary>
	/// The text content of the element.
	/// </summary>
	public string Content { get; set; } = "";

	/// <summary>
	/// The attributes of the element.
	/// </summary>
	public Dictionary<string, string> Attributes { get; set; } = new();

	/// <summary>
	/// Serializes this element, its attributes, and any children into minified HTML.
	/// </summary>
	public override string ToString() => Serialize();

	/// <summary>
	/// Creates a new HtmlElement with the given tag name.
	/// </summary>
	/// <param name="tag">The name of the element.</param>
	public Element(string tag) => _tag = tag;

	private string Serialize()
	{
		string serializedChildren = string.Join("", Children.Select(c => c.ToString()));
		string serializedAttributes = string.Join(" ", Attributes.Select(a => $"{a.Key}=\"{a.Value}\""));

		string start = serializedAttributes.Length > 0 ? $"<{_tag} {serializedAttributes}" : $"<{_tag}";
		string end = serializedChildren.Length > 0 || Content.Length > 0 ? $">{Content}{serializedChildren}</{_tag}>" : "/>";

		return start + end;
	}
}