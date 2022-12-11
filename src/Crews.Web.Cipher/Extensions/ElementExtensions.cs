using System.Web;
using Crews.Web.Cipher.Html;
using Microsoft.AspNetCore.Html;

namespace Crews.Web.Cipher.Extensions;

/// <summary>
/// Extension methods for Cipher.
/// </summary>
public static class ElementExtensions
{
	/// <summary>
	/// Converts an Element to an HtmlString for use in a web page.
	/// </summary>
	/// <param name="element">The element to convert.</param>
	/// <returns>Returns a new HtmlString representing the Element.</returns>
	public static HtmlString ToHtmlString(this Element element) =>
		new HtmlString(element.ToString());
}