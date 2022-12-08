using System.Web;
using Crews.Web.Cipher.Html;
using Microsoft.AspNetCore.Html;

namespace Crews.Web.Cipher.Extensions;

public static class ElementExtensions
{
	public static HtmlString ToHtmlString(this Element element) =>
		new HtmlString(element.ToString());
}