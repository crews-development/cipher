namespace Crews.Web.Cipher.Css;

/// <summary>
/// Represents a CSS media query.
/// </summary>
public class CssMediaQuery : CssRuleNestedAtRule
{
	/// <summary>
	/// The conditions of the query.
	/// </summary>
	public IEnumerable<string> ConditionSets { get; set; } = new List<string>();

	/// <summary>
	/// The query constructor.
	/// </summary>
	/// <param name="conditionSets">Conditions of the query. For example: "screen", "min-width: 1250px"</param>
	public CssMediaQuery(params string[] conditionSets)
		: base($"media " + string.Join(",", conditionSets)) { }
}