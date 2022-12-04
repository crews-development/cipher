namespace Crews.Web.Cipher.Tests;

public class HtmlElementTests
{
	[Fact]
	public void HtmlDocumentGeneratesExpectedString()
	{
		string expected = "<!DOCTYPE html><html><body><h1>Test</h1><p>This is a test.</p></body></html>";

		HtmlDocument document = new();
		BodyElement body = new();
		H1Element h1 = new();
		PElement p = new();

		h1.Content = "Test";
		p.Content = "This is a test.";

		body.Children.Add(h1);
		body.Children.Add(p);
		document.Children.Add(body);

		string actual = document.ToString();

		Assert.Equal(expected, actual);
	}
}