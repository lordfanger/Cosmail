using System.Web;

namespace Cosmail.Helper;

/// <summary>
/// Helper for &lt;iframe&gt; tag.
/// </summary>
public static class IframeHelper
{
	/// <summary>
	/// Convert HTML to src attribute for &lt;iframe&gt; tag.
	/// </summary>
	/// <param name="html">HTML to be used as source for &lt;iframe&gt;</param>
	/// <returns>Encoded HTML attribute value.</returns>
	public static string HtmlToSrc(string html) => $"data:text/html;charset=utf-8,{EncodeHtml(html)}";

	private static string EncodeHtml(string html) => HttpUtility.UrlEncode(html).Replace('+', ' ');
}