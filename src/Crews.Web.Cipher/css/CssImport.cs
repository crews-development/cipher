namespace Crews.Web.Cipher.Css;

public class CssImport : CssAtRule
{
	public CssImport(string import) : base($"import {import};") { }
}