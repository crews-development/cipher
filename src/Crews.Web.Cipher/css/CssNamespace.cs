namespace Crews.Web.Cipher.Css;

public class CssNamespace : CssAtRule
{
	public CssNamespace(string ns) : base($"namespace {ns};") { }
}