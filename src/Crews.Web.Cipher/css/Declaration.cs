namespace Crews.Web.Cipher.Css;

/// <summary>
/// Represents a single declaration of a CSS rule.
/// </summary>
public class Declaration
{
	/// <summary>
	/// The property defining the declaration.
	/// </summary>
	public string Property { get; set; }

	/// <summary>
	/// The declared value. Defaults to 'unset'.
	/// </summary>
	public string Value { get; set; }

	/// <summary>
	/// Creates a new CssDeclaration instance.
	/// </summary>
	/// <param name="property">The property defining the declaration.</param>
	/// <param name="value">The value of the declaration. If null, 'unset' is used.</param>
	public Declaration(string property, string? value = null)
	{
		Property = property;
		Value = value ?? "unset";
	}

	/// <summary>
	/// Gets the string representation of the declaration, terminated with a semicolon.
	/// </summary>
	/// <returns>Returns a string representing the declaration.</returns>
	public override string ToString()
	{
		string sanitizedProperty = Property.Replace(' ', '-');
		return $"{sanitizedProperty}:{Value};";
	}
}