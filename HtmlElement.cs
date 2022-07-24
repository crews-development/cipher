namespace Crews.Web.Cipher;

public abstract class HtmlElement
{
	private string _name;

	public List<HtmlElement> Children = new();
	public HtmlElement(string name) => _name = name;
}