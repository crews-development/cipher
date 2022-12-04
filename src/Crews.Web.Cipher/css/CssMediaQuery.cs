namespace Crews.Web.Cipher.Css;

public class CssMediaQuery : CssRuleNestedAtRule
{
	public IEnumerable<string> ConditionSets { get; set; } = new List<string>();

	public CssMediaQuery(params string[] conditionSets)
		: base($"media " + string.Join(",", conditionSets)) { }
}