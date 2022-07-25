namespace Crews.Web.Cipher;

/// <summary>
/// Represents an HTML element, its attributes, and its child elements.
/// </summary>
public abstract class HtmlElement
{
	private string _tag;

	/// <summary>
	/// The child elements contained in this element.
	/// </summary>
	public List<HtmlElement> Children { get; set; } = new();

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
	public HtmlElement(string tag) => _tag = tag;

	private string Serialize()
	{
		string serializedChildren = string.Join("", Children.Select(c => c.ToString()));
		string serializedAttributes = string.Join(" ", Attributes.Select(a => serializeAttribute(a)));

		string start = serializedAttributes.Length > 0 ? $"<{_tag} {serializedAttributes}" : $"<{_tag}";
		string end = serializedChildren.Length > 0 || Content.Length > 0 ? $">{Content}{serializedChildren}</{_tag}>" : "/>";

		return start + end;
	}

	private static string serializeAttribute(KeyValuePair<string, string> attribute)
	{
		// Check if value contains any characters that need quotes.
		bool needsQuotes = attribute.Value.IndexOfAny(new char[] { ' ', '"', '\'', '<', '>', '=', '`' }) != -1;
		string safeValue = needsQuotes ? $"\"{attribute.Value}" : attribute.Value;

		return $"{attribute.Key}={safeValue}";
	}
}