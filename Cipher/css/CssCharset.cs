namespace Crews.Web.Cipher.Css;

public class CssCharset : CssAtRule
{
	public CssCharset(string charset) : base($"charset \"{charset}\";") { }
}