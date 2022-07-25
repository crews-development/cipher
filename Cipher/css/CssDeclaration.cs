namespace Crews.Web.Cipher.Css;

public class CssDeclaration
{
	public string Property { get; set; }
	public string Value { get; set; }

	public CssDeclaration(string property, string? value = null)
	{
		Property = property;
		Value = value ?? "unset";
	}

	public override string ToString()
	{
		string sanitizedProperty = Property.Replace(' ', '-');
		return $"{sanitizedProperty}:{Value};";
	}
}