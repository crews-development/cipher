namespace Crews.Web.Cipher.Css;

/// <summary>
/// Represents a CSS namespace.
/// </summary>
public class Namespace : AtRule
{
	/// <summary>
	/// Namespace constructor.
	/// </summary>
	/// <param name="ns">The name of the namespace.</param>
	public Namespace(string ns) : base($"namespace {ns};") { }
}