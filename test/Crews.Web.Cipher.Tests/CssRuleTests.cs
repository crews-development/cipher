using Crews.Web.Cipher.Css.Selectors;

namespace Crews.Web.Cipher.Tests;

public class RuleTests
{
	[Fact]
	public void RuleGeneratesExpectedString()
	{
		string expected = "p::before{color:blue;width:10px}.myclass,h1{background:unset}#test:hover::after{color:#eee;font-weight:bold}";

		Selector selector1 = new("p", null, "before");
		Selector selector2a = new(".myclass");
		Selector selector2b = new("h1");
		Selector selector3 = new("#test", "hover", "after");

		Declaration declaration1a = new("color", "blue");
		Declaration declaration1b = new("width", "10px");

		Declaration declaration2 = new("background");

		Declaration declaration3a = new("color", "#eee");
		Declaration declaration3b = new("font-weight", "bold");

		Rule rule1 = new(selector1, new List<Declaration> { declaration1a, declaration1b });
		Rule rule2 = new(new List<Selector> { selector2a, selector2b }, new List<Declaration> { declaration2 });
		Rule rule3 = new(selector3, new List<Declaration> { declaration3a, declaration3b });

		string actual = string.Join("", new List<string> { rule1.ToString(), rule2.ToString(), rule3.ToString() });

		Assert.Equal(expected, actual);
	}
}