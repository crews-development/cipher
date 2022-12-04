namespace Crews.Web.Cipher.Tests;

public class CssRuleTests
{
	[Fact]
	public void CssRuleGeneratesExpectedString()
	{
		string expected = "p::before{color:blue;width:10px}.myclass,h1{background:unset}#test:hover::after{color:#eee;font-weight:bold}";

		CssSelector selector1 = new("p", null, "before");
		CssSelector selector2a = new(".myclass");
		CssSelector selector2b = new("h1");
		CssSelector selector3 = new("#test", "hover", "after");

		CssDeclaration declaration1a = new("color", "blue");
		CssDeclaration declaration1b = new("width", "10px");

		CssDeclaration declaration2 = new("background");

		CssDeclaration declaration3a = new("color", "#eee");
		CssDeclaration declaration3b = new("font-weight", "bold");

		CssRule rule1 = new(selector1, new List<CssDeclaration> { declaration1a, declaration1b });
		CssRule rule2 = new(new List<CssSelector> { selector2a, selector2b }, new List<CssDeclaration> { declaration2 });
		CssRule rule3 = new(selector3, new List<CssDeclaration> { declaration3a, declaration3b });

		string actual = string.Join("", new List<string> { rule1.ToString(), rule2.ToString(), rule3.ToString() });

		Assert.Equal(expected, actual);
	}
}