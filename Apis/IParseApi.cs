using System.Collections.Generic;
using SiteServer.Plugin.Models;

namespace SiteServer.Plugin.Apis
{
    public interface IParseApi
    {
        Dictionary<string, string> GetStlElements(string innerXml, List<string> stlElementNames);

        string ParseInnerXml(string innerXml, IPluginParseContext context);

        string ParseAttributeValue(string attributeValue, IPluginParseContext context);

        string HtmlToXml(string html);

        string XmlToHtml(string xml);

        string GetCurrentUrl(IPluginParseContext context);
    }
}
