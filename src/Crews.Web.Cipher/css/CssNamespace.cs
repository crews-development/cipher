namespace Crews.Web.Cipher.Css;

/// <summary>
/// Represents a CSS namespace.
/// </summary>
public class CssNamespace : CssAtRule
{
	/// <summary>
	/// Namespace constructor.
	/// </summary>
	/// <param name="ns">The name of the namespace.</param>
	public CssNamespace(string ns) : base($"namespace {ns};") { }
}